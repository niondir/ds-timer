using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.ComponentModel;

namespace DS_Timer.World
{
    public class WorldDownloader : INotifyPropertyChanged
    {
        private WebClient m_Web;
        private Queue<DownloadItem> m_DownloadQueue = new Queue<DownloadItem>();
        private bool m_IsDownloading = false; // Use m_Web.IsBusy instead?
        
        private string m_InfoString = String.Empty;
        private int m_ProcessPercentage = 0;

        public event EventHandler DownloadsComplete;

        public bool DownloadsPending
        {
            get { return m_DownloadQueue.Count > 0; }
        }

        public string InfoString
        {
            get { return m_InfoString; }
            private set
            {
                m_InfoString = value;
                NotifyPropertyChanged("InfoString");
            }
        }
        public int ProcessPercentage
        {
            get { return m_ProcessPercentage; }
            private set
            {
                m_ProcessPercentage = value;
                NotifyPropertyChanged("ProcessPercentage");
            }
        }


        public WorldDownloader(WebClient web)
        {
            m_Web = web;
            m_Web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(m_Web_DownloadProgressChanged);
            m_Web.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(m_Web_DownloadFileCompleted);
        }

        

        public void StartDownloads()
        {
            if (m_IsDownloading) return;
            NextDownload();
        }

        private void NextDownload()
        {
            if (m_DownloadQueue.Count == 0)
            {
                m_IsDownloading = false; // Just to be sure
                InfoString = "Alle Downloads beendet";
                if (DownloadsComplete != null)
                {
                    DownloadsComplete.Invoke(this, EventArgs.Empty);
                }
                return;
            }
            m_IsDownloading = true;
            DownloadItem item = m_DownloadQueue.Dequeue();
            try
            {
                m_Web.DownloadFileAsync(new Uri(item.Address), item.File, item);
                InfoString = "Starte Download von " + item.FileName;
                ProcessPercentage = 0;
            }
            catch (Exception)
            {
                m_IsDownloading = false;
                InfoString = "Fehler beim Download von " + item.FileName;
            }
        }

        public void AddDownload(string address, string file)
        {
            m_DownloadQueue.Enqueue(new DownloadItem(address, file));
        }

        void m_Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            ProcessPercentage = e.ProgressPercentage;
        }

        void m_Web_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            DownloadItem item = (DownloadItem)e.UserState;
            InfoString = "Download beendet: " + item.FileName;

            m_IsDownloading = false;
            ProcessPercentage = 100;
            NextDownload();
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
