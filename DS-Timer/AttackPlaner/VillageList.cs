using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DS_Timer.World;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
using DS_Timer.Localization;

namespace DS_Timer.AttackPlaner
{
	[XmlRoot]
	public class VillageList : INotifyPropertyChanged
	{
		private string m_Name;
		private BindingList<VillageInfo> m_Villages = new BindingList<VillageInfo>();


		public string Name
		{
			get { return m_Name; }
			set
			{
				m_Name = value;
				NotifyPropertyChanged("Name");
			}
		}

		public BindingList<VillageInfo> Villages
		{
			get { return m_Villages; }
			set { m_Villages = value; } // To Deserialize
		}
		
		
		public VillageList()
			: this(Translator.Translate("Neue Liste"))
		{

		}

		public VillageList(string name) {
			Name = name;
		}

		
		
		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string property)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
			}
		}

		#endregion

		#region serialization
		public static void SerializeToXml(BindingList<VillageList> items)
		{
			string dir = Program.GetUserDataPath();
			string file = Path.Combine(dir, "VillageLists.xml");

			XmlSerializer writer = new XmlSerializer(typeof(BindingList<VillageList>));
			TextWriter textWriter = new StreamWriter(file);
			writer.Serialize(textWriter, items);
			textWriter.Close();
		}

		public static BindingList<VillageList> DeserializeFromXml()
		{
			string dir = Program.GetUserDataPath();
			string file = Path.Combine(dir, "VillageLists.xml");

			try
			{
				XmlSerializer deserializer = new XmlSerializer(typeof(BindingList<VillageList>));
				TextReader textReader = new StreamReader(file);
				BindingList<VillageList> items;
				items = (BindingList<VillageList>)deserializer.Deserialize(textReader);
				textReader.Close();

				return items;
			}
			catch (Exception)
			{
				return new BindingList<VillageList>();
			}
		}
		#endregion

	}
}
