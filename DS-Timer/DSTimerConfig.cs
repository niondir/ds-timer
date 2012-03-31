using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using DS_Timer.World;

namespace DS_Timer
{
	[XmlRoot]
	public class DSTimerConfig
	{
		public static string DefaultPath
		{
			get { return Path.Combine(Program.GetUserDataPath(), "DSTimerConfig.xml"); }
		}

		private string m_currentPath;
		public List<Server> Servers { get; set; }

		private double m_SpearSpeed = 18;
		private double m_SwordSpeed = 22;
		private double m_AxeSpeed = 18;
		private double m_ArcherSpeed = 18;
		private double m_ScoutSpeed = 9;
		private double m_LCavSpeed = 10;
		private double m_MArchSpeed = 10;
		private double m_HCavSpeed = 11;
		private double m_RamSpeed = 30;
		private double m_CataSpeed = 30;
		private double m_SnobSpeed = 35;
		private double m_PalaSpeed = 10;

		public double SpearSpeed
		{
			get { return m_SpearSpeed; }
			set { m_SpearSpeed = value; }
		}

		public double SwordSpeed
		{
			get { return m_SwordSpeed; }
			set { m_SwordSpeed = value; }
		}

		public double AxeSpeed
		{
			get { return m_AxeSpeed; }
			set { m_AxeSpeed = value; }
		}

		public double ArcherSpeed
		{
			get { return m_ArcherSpeed; }
			set { m_ArcherSpeed = value; }
		}

		public double ScoutSpeed
		{
			get { return m_ScoutSpeed; }
			set { m_ScoutSpeed = value; }
		}

		public double LCavSpeed
		{
			get { return m_LCavSpeed; }
			set { m_LCavSpeed = value; }
		}

		public double MArchSpeed
		{
			get { return m_MArchSpeed; }
			set { m_MArchSpeed = value; }
		}

		public double HCavSpeed
		{
			get { return m_HCavSpeed; }
			set { m_HCavSpeed = value; }
		}

		public double RamSpeed
		{
			get { return m_RamSpeed; }
			set { m_RamSpeed = value; }
		}

		public double CataSpeed
		{
			get { return m_CataSpeed; }
			set { m_CataSpeed = value; }
		}

		public double SnobSpeed
		{
			get { return m_SnobSpeed; }
			set { m_SnobSpeed = value; }
		}

		public double PalaSpeed
		{
			get { return m_PalaSpeed; }
			set { m_PalaSpeed = value; }
		}



		public static DSTimerConfig LoadConfig(string file)
		{
			if (!File.Exists(file))
			{
				var config = new DSTimerConfig();
				config.m_currentPath = file;
				return config;
			}
			XmlSerializer serializer = new XmlSerializer(typeof(DSTimerConfig));
			using (Stream stream = new FileStream(file, FileMode.Open))
			{
				var config = (DSTimerConfig) serializer.Deserialize(stream);
				config.m_currentPath = file;
				return config;
			}
		}

		public void SaveConfig()
		{
			SaveConfig(m_currentPath);
		}

		public void SaveConfig(string file)
		{
			XmlSerializer serializer = new XmlSerializer(this.GetType());
			using (Stream stream = new FileStream(file, FileMode.Create))
			{
				serializer.Serialize(stream, this);
			}
		}


	}
}
