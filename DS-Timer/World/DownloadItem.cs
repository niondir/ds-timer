using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DS_Timer.World
{
    public class DownloadItem
    {
        public string Address { get; private set; }
        public string File { get; private set; }

        public string FileName
        {
            get { return Path.GetFileName(File); }
        }

        public DownloadItem(string address, string file)
        {
            Address = address;
            File = file;
        }
    }
}
