using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
using DS_Timer.Util;
using DS_Timer.Properties;
using DS_Timer.Localization;

namespace DS_Timer.AttackPlaner
{
	public class AttackPlan
	{
		private string m_Name;
		private SortableBindingList<AttackOrder> m_AttackOrders = new SortableBindingList<AttackOrder>();


		public string Name
		{
			get { return m_Name; }
			set
			{
				m_Name = value;
				NotifyPropertyChanged("Name");
			}
		}

		public SortableBindingList<AttackOrder> AttackOrders
		{
			get { return m_AttackOrders; }
			set { m_AttackOrders = value; } // To Deserialize
		}
		
		
		public AttackPlan()
			: this(Translator.Translate("Neuer Plan"))
		{

		}

		public AttackPlan(string name)
		{
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
		public static void SerializeToXml(BindingList<AttackPlan> items)
		{
			string dir = Program.GetUserDataPath();
			string file = Path.Combine(dir, "AtackPlans.xml");

			XmlSerializer writer = new XmlSerializer(typeof(BindingList<AttackPlan>));
			TextWriter textWriter = new StreamWriter(file);
			writer.Serialize(textWriter, items);
			textWriter.Close();
		}

		public static BindingList<AttackPlan> DeserializeFromXml()
		{
			string dir = Program.GetUserDataPath();
			string file = Path.Combine(dir, "AtackPlans.xml");

			try
			{
				XmlSerializer deserializer = new XmlSerializer(typeof(BindingList<AttackPlan>));
				TextReader textReader = new StreamReader(file);
				BindingList<AttackPlan> items;
				items = (BindingList<AttackPlan>)deserializer.Deserialize(textReader);
				textReader.Close();

				return items;
			}
			catch (Exception)
			{
				return new BindingList<AttackPlan>();
			}
		}
		#endregion
	}
}
