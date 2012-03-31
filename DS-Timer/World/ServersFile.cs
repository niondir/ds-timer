using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace DS_Timer.World
{
	public class ServersFile : WorldFile
	{
		private List<WorldInfo> m_WorldInfo = new List<WorldInfo>();

		public IList<WorldInfo> WorldInfo
		{
			get { return m_WorldInfo.AsReadOnly(); }
		}

		public string Url { get; set; }

		public ServersFile(string file, string url)
			: base(file)
		{
			Url = url;
		}


		public override void ParseFile()
		{
			string text = File.ReadAllText(this.FilePath);
			string pat = "\"(.)*?\"";

			Regex r = new Regex(pat, RegexOptions.Multiline);
			MatchCollection matches = r.Matches(text);
			if (matches.Count % 2 != 0)
			{
				throw new Exception("Server list has bad Format.");
			}

			for (int i = 0; i + 1 < matches.Count; i += 2)
			{
				string m = matches[i].Groups[0].Value;
				string name = matches[i].Value.Trim('\"');
				string server = matches[i + 1].Value.Trim('\"');
				m_WorldInfo.Add(new WorldInfo(name, server));
			}
		}

		
	}
}
