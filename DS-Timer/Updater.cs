using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using updateSystemDotNet;
using System.Windows.Forms;
using DS_Timer.Properties;
using DS_Timer;

namespace Niondir
{
    public class Updater
    {
        public event EventHandler ExitApplication;

        private string _updateUrl;
        private string _projectId;
        private string _publicKey;
        private string _version;

        private updateController m_Controller;

        public updateController Controller
        {
            get { return m_Controller; }
        }

        public Updater(string version, string projectId, string publicKey, string updateUrl)
        {
            _updateUrl = updateUrl;
            _version = version.ToString();
            _projectId = projectId;
            _publicKey = publicKey;

            m_Controller = new updateController(_updateUrl, _version, _publicKey);
            m_Controller.projectId = _projectId;

            m_Controller.updateInstallerStarted += (s, e) =>
            {
                if (ExitApplication != null)
                {
                    ExitApplication.Invoke(this, EventArgs.Empty);
                }
            };
        }

        /// <summary>
        /// Settings.Default.UpdateUrl must be the update URL
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public bool RunUpdater()
        {
            try
            {
#if DEBUG
                return false;
#endif

                m_Controller.Language = Languages.Deutsch;
                m_Controller.releaseFilter.checkForBeta = Settings.Default.DownloadBeta;
                m_Controller.releaseFilter.checkForAlpha = Program.CheckForAlpha;
                m_Controller.restartApplication = true;     

#if TESTRELEASE
            updater.allowBetaversions = true;
#endif

                //if (updater.checkForUpdatesDialog() != DialogResult.OK) { return false; }
                if (!m_Controller.checkForUpdates()) { return false; }

                if (m_Controller.showUpdateDialog() == DialogResult.OK)
                {
                    if (m_Controller.downloadUpdatesDialog() == DialogResult.OK)
                    {
                        m_Controller.applyUpdate();
                        return true;
                    }
                }
            }
            catch(Exception ex) {
				Console.WriteLine(ex);
				MessageBox.Show("Updateserver nicht erreichbar.");
                return false;
            }
            return false;
        }
    }
}
