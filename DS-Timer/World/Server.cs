using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DS_Timer.World
{
	[XmlRoot]
	public class Server
	{
		/// <summary>
		/// The name, usually the country
		/// </summary>
		[XmlAttribute("Name")]
		public String Name { get; set; }
		[XmlAttribute]
		public String BaseUrl { get; set; }
		[XmlIgnore]
		public String DisplayName { get { return String.Format("{0}: {1}", Name, BaseUrl); } }

		/// <summary>
		/// For Serialization
		/// </summary>
		public Server()
		{
			
		}

		public Server(String name, String baseUrl)
		{
			Name = name;
			BaseUrl = baseUrl.TrimEnd('/', '\\', '?');
		}

		public ServersFile getServerFile(string downloadDir)
		{
			return new ServersFile(Path.Combine(downloadDir, "servers_" + Name + ".txt"), BaseUrl + "/backend/get_servers.php");
		}
	}
}
