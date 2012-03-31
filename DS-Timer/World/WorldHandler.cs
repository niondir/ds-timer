using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net;
using DS_Timer.Properties;
using System.IO;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Core;
using System.Windows.Forms;

namespace DS_Timer.World
{
	public class WorldHandler
	{
		private BindingList<WorldInfo> m_Wolrds = new BindingList<WorldInfo>();
		private string m_DownloadDir;

		private static WorldConfigFile m_ConfigFile;
		private static VillageFile m_VillageFile;
		private static PlayerFile m_PlayerFile;

		private static List<ServersFile> m_ServersFiles = new List<ServersFile>();

		public BindingList<WorldInfo> Wolrds
		{
			get { return m_Wolrds; }
		}

		public static WorldConfigFile ConfigFile
		{
			get { return m_ConfigFile; }
			private set { m_ConfigFile = value; }
		}

		public static VillageFile VillageFile
		{
			get { return m_VillageFile; }
			private set { m_VillageFile = value; }
		}

		public static PlayerFile PlayerFile
		{
			get { return m_PlayerFile; }
			private set { m_PlayerFile = value; }
		}

		/*
		public static List<ServersFile> ServersFiles
		{
			get { return WorldHandler.m_ServersFileDe; }
			private set { WorldHandler.m_ServersFileDe = value; }
		}*/

		public WorldInfo World { get; private set; }

		public static decimal WorldSpeed
		{
			get
			{
				return ConfigFile.WorldSpeed;
				//return Properties.Settings.Default.WorldSpeedFactor; 
			}
		}

		public static decimal UnitSpeed
		{
			get
			{
				return ConfigFile.WorldUnitSpeed;
				//return Properties.Settings.Default.WorldUnitSpeedFactor; 
			}
		}


		public DateTime LastWorldDownload
		{
			get
			{
				if (!File.Exists(m_ConfigFile.FilePath)) return DateTime.MinValue;
				return File.GetLastWriteTime(m_ConfigFile.FilePath);
			}
		}


		public WorldHandler()
		{
			m_DownloadDir = Program.GetUserDataPath();

			m_ConfigFile = new WorldConfigFile(Path.Combine(m_DownloadDir, "worldConfig.xml"));
			m_PlayerFile = new PlayerFile(Path.Combine(m_DownloadDir, "player.txt"));
			m_VillageFile = new VillageFile(Path.Combine(m_DownloadDir, "village.txt"));

			m_ServersFiles.Add(new ServersFile(Path.Combine(m_DownloadDir, "servers_de.txt"), "http://www.die-staemme.de/backend/get_servers.php"));
			m_ServersFiles.Add(new ServersFile(Path.Combine(m_DownloadDir, "servers_ch.txt"), "http://www.staemme.ch/backend/get_servers.php"));
			m_ServersFiles.Add(new ServersFile(Path.Combine(m_DownloadDir, "servers_en.txt"), "http://www.tribalwars.net/backend/get_servers.php"));
			
			m_Wolrds.Add(new WorldInfo("Welt wählen", "", 1, 1));
			DownloadServerInfo(); // Fill the WorldInfo
			
			
			
			ParseFiles();
		}

		private void DownloadServerInfo()
		{
			WebClient web = new WebClient();
			WorldDownloader serverInfoDownloader = new WorldDownloader(web);
			serverInfoDownloader.DownloadsComplete += new EventHandler(serverInfoDownloader_DownloadsComplete);

			foreach (ServersFile sf in m_ServersFiles)
			{
				serverInfoDownloader.AddDownload(sf.Url, sf.FilePath);
			}

			serverInfoDownloader.StartDownloads();
		}

		void serverInfoDownloader_DownloadsComplete(object sender, EventArgs e)
		{
			foreach (ServersFile sf in m_ServersFiles)
			{
				sf.ParseFile();

				foreach (WorldInfo i in sf.WorldInfo)
				{
					m_Wolrds.Add(i);
				}
			}
		}

		private void AddDefaultWorldInfo()
		{
			AddUniqueWorldInfo(new WorldInfo("de3", "http://de3.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de4", "http://de4.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de5", "http://de5.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de6", "http://de6.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de7", "http://de7.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de8", "http://de8.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de9", "http://de9.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de10", "http://de10.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de11", "http://de11.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de12", "http://de12.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de13", "http://de13.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de14", "http://de14.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de15", "http://de15.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de16", "http://de16.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de17", "http://de17.die-staemme.de", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("de18", "http://de19.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de19", "http://de19.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de20", "http://de20.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de21", "http://de21.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de22", "http://de22.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de23", "http://de23.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de24", "http://de24.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de25", "http://de25.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de26", "http://de26.die-staemme.de", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("de27", "http://de27.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de28", "http://de28.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de29", "http://de29.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de30", "http://de30.die-staemme.de", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("de31", "http://de31.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de32", "http://de32.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de33", "http://de33.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de34", "http://de34.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de35", "http://de35.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de36", "http://de36.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de37", "http://de37.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de38", "http://de38.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de39", "http://de39.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de40", "http://de40.die-staemme.de", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("de41", "http://de41.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de42", "http://de42.die-staemme.de", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("de43", "http://de43.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de44", "http://de44.die-staemme.de", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("de45", "http://de45.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de46", "http://de46.die-staemme.de", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("de46", "http://de46.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de47", "http://de47.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de48", "http://de48.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de49", "http://de49.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de50", "http://de50.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de51", "http://de51.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de52", "http://de52.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de53", "http://de53.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de54", "http://de54.die-staemme.de", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("de55", "http://de55.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de56", "http://de56.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de57", "http://de57.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de58", "http://de58.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de59", "http://de59.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de60", "http://de60.die-staemme.de", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("de61", "http://de53.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de62", "http://de53.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de63", "http://de53.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de64", "http://de53.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de65", "http://de53.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de66", "http://de53.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de67", "http://de53.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de68", "http://de68.die-staemme.de", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("de69", "http://de69.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de70", "http://de70.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de71", "http://de71.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de72", "http://de72.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de73", "http://de73.die-staemme.de", 2, 0.75m));
			AddUniqueWorldInfo(new WorldInfo("de74", "http://de74.die-staemme.de", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("de75", "http://de75.die-staemme.de", 2, 1));

			// + Schweizer
			AddUniqueWorldInfo(new WorldInfo("ch1", "http://ch1.staemme.ch", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("ch2", "http://ch2.staemme.ch", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("ch3", "http://ch3.staemme.ch", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("ch4", "http://ch4.staemme.ch", 1.6m, 1));
			AddUniqueWorldInfo(new WorldInfo("ch5", "http://ch5.staemme.ch", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("ch6", "http://ch6.staemme.ch", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("ch7", "http://ch7.staemme.ch", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("ch8", "http://ch8.staemme.ch", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("ch9", "http://ch9.staemme.ch", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("ch10", "http://ch10.staemme.ch", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("ch11", "http://ch11.staemme.ch", 1.6m, 0.625m));
			AddUniqueWorldInfo(new WorldInfo("ch12", "http://ch12.staemme.ch", 1.6m, 1));
			AddUniqueWorldInfo(new WorldInfo("ch13", "http://ch13.staemme.ch", 1, 1));
			AddUniqueWorldInfo(new WorldInfo("ch14", "http://ch14.staemme.ch", 1.6m, 0.625m));
		}

		private bool AddUniqueWorldInfo(WorldInfo info)
		{
			foreach (WorldInfo i in m_Wolrds)
			{
				if (i.Server == info.Server)
				{
					return false;
				}
			}
			m_Wolrds.Add(info);
			return true;
		}

		public void SetServer(string server)
		{
			Settings.Default.DSServer = server;
			foreach (WorldInfo w in m_Wolrds)
			{
				if (w.Server == server)
				{
					World = w;
					return;
				}
			}
			World = new WorldInfo("Eigene", server, 1, 1);
		}

		public WorldDownloader DownloadWorldData()
		{
			if (World == null)
			{
				throw new NullReferenceException("WorldHandler.World is null");
			}

			WebClient web = new WebClient();
			WorldDownloader downloader = new WorldDownloader(web);
			downloader.DownloadsComplete += new EventHandler(downloader_DownloadsComplete);

			downloader.AddDownload(World.Server + "/interface.php?func=get_config", m_ConfigFile.FilePath);
			downloader.AddDownload(World.Server + "/map/village.txt.gz", m_VillageFile.FilePath + ".gz");
			downloader.AddDownload(World.Server + "/map/player.txt.gz", m_PlayerFile.FilePath + ".gz");

			downloader.StartDownloads();
			return downloader;

			// TODO: Download the world data from the DS server:
			// /map/ally.txt.gz - NOT YET
			// /map/conquer.txt.gz - NOT YET
			// /map/profile.txt.gz - NOT YET

			/*
 Die einzelnen Daten sind mit Hilfe der PHP-Funktion urlencode() codiert, dh. dass zB. ein Komma durch %2C ersetzt ist.

/map/ally.txt - /map/ally.txt.gz
In dieser Datei sind Informationen über die Stämme. Die Daten stehen in folgender Reihenfolge zur Verfügung:

$id, $name, $tag, $members, $villages, $points, $all_points, $rank
/map/conquer.txt - /map/conquer.txt.gz
In dieser Datei sind alle Adelungen seit Beginn der Welt enthalten. Die Daten stehen in folgender Reihenfolge zur Verfügung:

$village_id, $unix_timestamp, $new_owner, $old_owner
/interface.php?func=get_conquer&since=unix_timestamp
Über diese Funktion kann man sich alle Adelungen seit dem letzten Unix-Timestamp ausgeben lassen. Der Timestamp darf maximal 24 Stunden zurück liegen. Die Daten stehen in folgender Reihenfolge zur Verfügung:

$village_id, $unix_timestamp, $new_owner, $old_owner
/map/profile.txt - /map/profile.txt.gz
In dieser Datei sind die Profildaten der Spieler. Die Daten stehen in folgender Reihenfolge zur Verfügung:

$player_id, Geburtstag, Geschlecht, Wohnort, Profiltext (als XHTML), Profilbild-Dateiname
/interface.php?func=get_config
Über diese Funktion kann man die Konfiguration der Welt auslesen (Format: XML).
			 * */
		}

		void downloader_DownloadsComplete(object sender, EventArgs e)
		{
			UnpackFiles();
			ParseFiles();
		}

		private void UnpackFiles()
		{
			try
			{
				m_PlayerFile.ExtractGZip(m_PlayerFile.FilePath + ".gz");
				m_VillageFile.ExtractGZip(m_VillageFile.FilePath + ".gz");
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error in downloaded files: " + ex.Message);
			}
		}

		private void ParseFiles()
		{
			try
			{
				m_ConfigFile.ParseFile();
				m_PlayerFile.ParseFile();
				m_VillageFile.ParseFile();
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error in world files: " + ex.Message);
			}

		}





	}
}
