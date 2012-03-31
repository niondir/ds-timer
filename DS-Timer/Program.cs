using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Niondir;
using DS_Timer.Properties;
using System.ComponentModel;
using System.Reflection;
using System.IO;
using System.Net;
using DS_Timer.TimeSync;
using System.Globalization;
using System.Threading;

namespace DS_Timer
{
	/**
	 * Stämme Interface: http://forum.die-staemme.de/showthread.php?t=71112
	 * */

	/* User Bugs:
	 * kannst du die sortierung nach zieldorf bzw startdorf korrigieren

	 * 

	 * 
	 * 
	 Import DS TImer exports :)
	 */

	/* TODO:
	 * Bugs:
	 * - Auto Upater: exe läuft noch
	 * - Aktualisieren der Dorfdaten gibt ungülltige Dörfer im Dorfmanager
	 * -- Geladene Dorfliste hat falsche Daten
	 * 
	 * 
	 * Aktuell: 
	 * - Drag & Dop für Dorfliste
	 * - Dorfliste button: Nach Namen sortieren
	 * - DS-Timer import
	 * 
	 * Attack Planer:
	 * - Export durch Strg + c
	 * - Export: Exportierte Daten detailiert einstellbar
	 * - 1. Spalte: Bild mit langsamster Einheit
	 * - Browser für Angriffe wählbar
	 * - BB Code update: Langsmaste Einheit als Bild (?)
	 * - Art des Angriffs (?)
	 * 
	 * UnitCalc:
	 * - Kosten pro Stunde
	 * - Bonusdörfer
	 * - Einheitendaten imporiteren
	 * -- http://de69.die-staemme.de/interface.php?func=get_unit_info
	 * -- build_time inclusive WorldSpeed
	 * - Gebäudeinfo mportieren
	 * -- http://de69.die-staemme.de/interface.php?func=get_building_info
	 * - Berechnungen speichern
	 * 
	 * Alarm:
	 * - Lautstärke regelbar
	 * 
	 * Sonstiges:
	 * - Zustimmungsrechner
	 * - Splashscreen
	 * - Mehr im Hintergrund machen (Time Sync, Model initialisierung)
	 * - Übersicht mit: Nächstem Angriff, Befehl und Alarm
	 * 
	 * 
	 * - User Feedback
	 * - Laufzeitrechner, der alle Fälle behandel
	 * - Erinnerung die Weltdaten neu zu laden, alle 24h?
	 * - Profile für mehrere server
	 * 
	 * Refactoring:
	 * - Programmlogik in eigene DLL und von GUI trennen
	 * 
	 * Changelog:
	 * 
	 * */

	public enum LanguageType
	{
		Default,
		English,
		German = Default
	}

	static class Program
	{
		public static Updater Updater;
		public static bool CheckForAlpha = false;

		public static LanguageType Language;

		private static string UpdaterPublicKey = @"<RSAKeyValue><Modulus>ojyXDJQrTKYMyeKbm64VXJTkaHdgfpMXQYfbMy0euSsM1W8wk01R64WLmLSGvY2SE0yKhupK9qZS47He9GjW6s59jSFN0xQvBKI2WNGUB6AnjW2pkriEKRazcm+/S4fLVCfvSrhl4OZ0u/lGfFEIrc2Q7oJkeudI2sqHeD5ct9E=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		private static string ProjectId = "d510b8c0-4086-4e09-a275-1d6b5f7c891a";

		static public string GetUserDataPath()
		{
			string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

			dir = System.IO.Path.Combine(dir, "DS-Timer");
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);
			return dir;
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			DSTimerConfig config = DSTimerConfig.LoadConfig(DSTimerConfig.DefaultPath);
			config.SaveConfig(DSTimerConfig.DefaultPath);

			switch (Settings.Default.Language.ToLower())
			{
				case "deutsch":
					Application.CurrentCulture = new CultureInfo("de-DE");
					Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
					Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
					Language = LanguageType.German;
					break;
				case "english":
					Application.CurrentCulture = new CultureInfo("en-US");
					Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
					Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
					Language = LanguageType.English;
					break;
			}


			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

			TimeSyncHandler.SyncTime();

			// Config file:
			//Console.WriteLine(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

			//Version version = new Version(Settings.Default.UpdateVersion);
			//Application.ProductVersion

			Updater = new Updater(Application.ProductVersion, ProjectId, UpdaterPublicKey, Settings.Default.UpdateUrl);

			if (Language == LanguageType.Default)
			{
				Updater.Controller.Language = updateSystemDotNet.Languages.Deutsch;
			}
			else
			{
				Updater.Controller.Language = updateSystemDotNet.Languages.English;
			}

			Updater.ExitApplication += new EventHandler(Updater_ExitApplication);

			if (TimeSyncHandler.Now.AddHours(-24) > Updater.Controller.lastSuccessfullUpdateCheck)
			{
				if (Updater.RunUpdater()) return;
			}

			if (Settings.Default.LastStart.DayOfYear != TimeSyncHandler.Now.DayOfYear)
			{
				try
				{
					HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dstools.agrafix.net/vote/161.html");
					request.GetResponse();
				}
				catch (Exception)
				{

				}
			}


			Settings.Default.LastStart = TimeSyncHandler.Now;
			Settings.Default.Save();
			Application.Run(new FormMain());
		}

		static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			MessageBox.Show("Error:\n" + e.ExceptionObject.ToString());
		}

		static void Updater_ExitApplication(object sender, EventArgs e)
		{
			Application.Exit(); // Better for WinForms?
			//Environment.Exit(0);
		}
	}
}
