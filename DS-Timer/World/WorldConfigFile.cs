using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.ComponentModel;
using System.Globalization;

namespace DS_Timer.World
{
    public class WorldConfigFile : WorldFile, INotifyPropertyChanged
    {
        private decimal m_WorldSpeed = 1;
        private decimal m_WorldUnitSpeed = 1;

        public decimal WorldSpeed
        {
            get { return m_WorldSpeed; }
            set
            {
                m_WorldSpeed = value;
                NotifyPropertyChanged("WorldSpeed");
            }
        }

        public decimal WorldUnitSpeed
        {
            get { return m_WorldUnitSpeed; }
            set
            {
                m_WorldUnitSpeed = value;
                NotifyPropertyChanged("WorldUnitSpeed");
            }
        }


        public WorldConfigFile(string file)
            : base(file)
        {
        }

        public override void ParseFile()
        {
            //m_Villages.Clear();
            if (!File.Exists(FilePath))
            {
                return;
            }

            XmlDocument xmlDoc = new XmlDocument(); //* create an xml document object.
            xmlDoc.Load(FilePath); //* load the XML document from the specified file.

            IFormatProvider provider = new CultureInfo("en-US");


            XmlNodeList speedNodes = xmlDoc.GetElementsByTagName("speed");
            double worldSpeed;
            double.TryParse(speedNodes[0].InnerXml, NumberStyles.Any, provider, out worldSpeed);
            WorldSpeed = (decimal)worldSpeed;

            double worldUnitSpeed;
            XmlNodeList unitSpeedNodes = xmlDoc.GetElementsByTagName("unit_speed");
            double.TryParse(unitSpeedNodes[0].InnerXml, NumberStyles.Any, provider, out worldUnitSpeed);
            WorldUnitSpeed = (decimal)worldUnitSpeed;
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

    }
}
