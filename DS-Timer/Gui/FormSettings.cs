using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS_Timer.Properties;
using DS_Timer.Alarm;
using System.Diagnostics;
using System.IO;
using DS_Timer.World;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using DS_Timer.TimeSync;
using System.Threading;
using System.Net;

namespace DS_Timer.Gui
{
	public partial class FormSettings : Form
	{
		private WorldHandler m_WorldHandler;
		private bool m_Initializing;

		public FormSettings(WorldHandler worldHandler)
		{
			m_Initializing = true;
			m_WorldHandler = worldHandler;
			InitializeComponent();
			Settings.Default.PropertyChanged += new PropertyChangedEventHandler(Default_PropertyChanged);
			Settings.Default.SettingsSaving += new System.Configuration.SettingsSavingEventHandler(Default_SettingsSaving);
			worldInfoBindingSource.DataSource = worldHandler.Wolrds;
			worldConfigFileBindingSource.DataSource = WorldHandler.ConfigFile;
			// TODO: try to load/select saved Server and World

			serversBindingSource.DataSource = worldHandler.Servers;

			Server selectedServer = worldHandler.Servers.FirstOrDefault(s => s.Name == Settings.Default.SelectedServerName);
			if (selectedServer != null)
			{
				serversBindingSource.Position = worldHandler.Servers.IndexOf(selectedServer);
			}
			UpdateLastWorldUpdateLabel();

			// Maybe a bad idea when server not avalible. Async testing?
			TestServer();
			m_Initializing = false;
		}

		private void FormSettings_Load(object sender, EventArgs e)
		{
		}
		private void FormSettings_Shown(object sender, EventArgs e)
		{
			System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12; //enable TLS 1.1 and 1.2
			DownloadServerInfo();
		}

		void Default_SettingsSaving(object sender, CancelEventArgs e)
		{
			btnAccept.Enabled = false;
			btnResetSettings.Enabled = false;
		}

		void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			btnAccept.Enabled = true;
			btnResetSettings.Enabled = true;
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			Server currentServer = (Server)serversBindingSource.Current;
			Settings.Default.SelectedServerName = currentServer == null ? "" : currentServer.Name;

			WorldInfo currentWorld = (WorldInfo)worldInfoBindingSource.Current;
			Settings.Default.SelectedWorldName = currentWorld == null ? "" : currentWorld.Name;


			Settings.Default.Save();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();
			this.Close();
		}



		private void btnResetSettings_Click(object sender, EventArgs e)
		{
			Settings.Default.Reload();
		}

		private void btnTestSound_Click(object sender, EventArgs e)
		{
			AlarmHandler.PlaySound();
		}

		private void btnOpenAlarmFile_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Filter = "*.wav Files|*.wav";
				ofd.Multiselect = false;
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					Settings.Default.AlarmSoundFile = ofd.FileName;
				}
			}
		}

		private void btnCheckUpdate_Click(object sender, EventArgs e)
		{
			if (!Program.Updater.RunUpdater())
			{
				MessageBox.Show("Keine Updates verfügbar", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		string m_Password;
		private void FormSettings_KeyUp(object sender, KeyEventArgs e)
		{
			char c = (char)e.KeyValue;

			if (c == 'X')
			{
				m_Password = String.Empty;
				Program.CheckForAlpha = false;
				this.BackColor = SystemColors.Control;
				return;
			}

			m_Password += c;
			if (m_Password.ToLower() == "alpha")
			{
				Program.CheckForAlpha = true;
				this.BackColor = Color.White;
			}
		}

		private void btnConfigDir_Click(object sender, EventArgs e)
		{
			// Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
			Process.Start(Program.GetUserDataPath());
		}

		private void worldInfoBindingSource_CurrentItemChanged(object sender, EventArgs e)
		{
			if (worldInfoBindingSource.Current == null) return;
			//WorldInfo info = (WorldInfo)worldInfoBindingSource.Current;
			//numWorldSpeed.Value = info.WorldSpeed;
			//numUnitSpeed.Value = info.UnitSpeed;
		}

		private void btnLoadWorldData_Click(object sender, EventArgs e)
		{
			m_WorldHandler.SetServer(txtServer.Text);
			WorldDownloader downloader = m_WorldHandler.DownloadWorldData();
			worldDownloaderBindingSource.DataSource = downloader;
			downloader.DownloadsComplete += new EventHandler(downloader_DownloadsComplete);
		}

		void downloader_DownloadsComplete(object sender, EventArgs e)
		{
			UpdateLastWorldUpdateLabel();
		}

		private void UpdateLastWorldUpdateLabel()
		{
			DateTime lastUpdate = m_WorldHandler.LastWorldDownload;
			if (lastUpdate == DateTime.MinValue)
			{
				lblLastWorldUpdate.Text = "Noch nie";
			}
			else
			{
				lblLastWorldUpdate.Text = m_WorldHandler.LastWorldDownload.ToString("dd.MM.yyyy HH:mm:ss");
			}

			if (lastUpdate.AddDays(7) < TimeSyncHandler.Now)
			{
				lblLastWorldUpdate.BackColor = Color.LightCoral;
			}
			else if (lastUpdate.AddDays(1) < TimeSyncHandler.Now)
			{
				lblLastWorldUpdate.BackColor = Color.Orange;
			}
			else if (lastUpdate.AddHours(1) < TimeSyncHandler.Now)
			{
				lblLastWorldUpdate.BackColor = Color.LightGreen;
			}
			else
			{
				lblLastWorldUpdate.BackColor = Color.LimeGreen;
			}
		}

		private void txtServer_Validated(object sender, EventArgs e)
		{
			m_WorldHandler.SetServer(txtServer.Text);
			TestServer();
		}

		private void TestServer()
		{
			txtServer.BackColor = Color.DarkOrange;
			if (PingServer(txtServer.Text))
			{
				txtServer.BackColor = Color.LightGreen;
			}
			else
			{
				txtServer.BackColor = Color.Red;
			}
		}



		private bool PingServer(string url)
		{
			url = url.Replace("http://", "");
			url = url.Replace("https://", "");
			Ping ping = new Ping();
			try
			{
				PingReply result = ping.Send(url);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		private void cbDSWorld_SelectedIndexChanged(object sender, EventArgs e)
		{
			//m_WorldHandler.SetServer((string)cbDSWorld.SelectedValue);
			//TestServer();
		}

		private void cbDSWorld_SelectionChangeCommitted(object sender, EventArgs e)
		{
			//m_WorldHandler.SetServer((string)cbDSWorld.SelectedValue);
			//TestServer();
		}

		private void pbDownloadPercentage_Click(object sender, EventArgs e)
		{

		}

		private void cbDSWorld_Validated(object sender, EventArgs e)
		{
			//m_WorldHandler.SetServer((string)cbDSWorld.SelectedValue);
			//TestServer();
		}

		private void BtnSetLanguage_Click(object sender, EventArgs e)
		{
			Settings.Default.Save();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSettings));

			if (MessageBox.Show("Restart DS-Timer?", "Restart", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Application.Restart();
				//Environment.Exit(0);
			}


		}

		private void btnAddWebsite_Click(object sender, EventArgs e)
		{
			DialogAddServer dialog = new DialogAddServer(serversBindingSource);

			dialog.FormClosed += (o, args) =>
			{
				Program.Config.SaveConfig();
			};

			dialog.ShowDialog(this);
		}

		private void worldDownloaderBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void btnDeleteWebsite_Click(object sender, EventArgs e)
		{
			if (serversBindingSource.Current != null)
			{
				serversBindingSource.RemoveCurrent();
				Program.Config.SaveConfig();
			}
		}

		private void serversBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			if (m_Initializing)
			{
				return;
			}
			DownloadServerInfo();
		}

		private void DownloadServerInfo()
		{
			m_WorldHandler.Wolrds.Clear();
			Server current = (Server)serversBindingSource.Current;
			if (current != null)
			{
				var downloader = m_WorldHandler.DownloadServerInfo(current);
				worldDownloaderBindingSource.DataSource = downloader;
				downloader.DownloadsComplete += (sender, args) =>
					{
						WorldInfo selectedWorld = m_WorldHandler.Wolrds.FirstOrDefault(s => s.Name == Settings.Default.SelectedWorldName);
						if (selectedWorld != null)
						{
							worldInfoBindingSource.Position = m_WorldHandler.Wolrds.IndexOf(selectedWorld);
						}
					};
			}
		}

		private void cbServer_SelectionChangeCommitted(object sender, EventArgs e)
		{

		}

		private void worldInfoBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			if (m_Initializing)
			{
				return;
			}
			WorldInfo current = (WorldInfo)worldInfoBindingSource.Current;
			if (current != null && !String.IsNullOrEmpty(current.Server))
			{
				m_WorldHandler.SetServer(current.Server);
				TestServer();
			}

		}


	}
}
