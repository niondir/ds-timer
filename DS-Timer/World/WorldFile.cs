using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Core;
using System.IO;
using ICSharpCode.SharpZipLib.GZip;

namespace DS_Timer.World
{
    public abstract class WorldFile
    {
        public string FilePath { get; private set; }

        public WorldFile(string file)
        {
            FilePath = file;
        }

        public abstract void ParseFile();

        /// <summary>
        /// Extract a GZip compressed file to the location of the WorldFile
        /// GZip can contain only one file
        /// </summary>
        /// <param name="gzipFileName"></param>
        public void ExtractGZip(string gzipFileName)
        {
            byte[] dataBuffer = new byte[4096];

            using (System.IO.Stream fs = new FileStream(gzipFileName, FileMode.Open, FileAccess.Read))
            {
                using (GZipInputStream gzipStream = new GZipInputStream(fs))
                {
                    // Change this to your needs
                    string fnOut = Path.Combine(Path.GetDirectoryName(gzipFileName), FilePath);

                    using (FileStream fsOut = File.Create(fnOut))
                    {
                        StreamUtils.Copy(gzipStream, fsOut, dataBuffer);
                    }
                    //return fnOut;
                }
            }
        }
    }
}
