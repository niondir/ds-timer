using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.Localization
{
	public class Translator
	{
		private static Dictionary<String, String> m_TranslationsEn = new Dictionary<string, string>();

		public static String Translate(string msg)
		{
			if (Program.Language == LanguageType.Default)
			{
				return msg;
			}

			if (Program.Language == LanguageType.English)
			{
				if (m_TranslationsEn.ContainsKey(msg))
				{
					return m_TranslationsEn[msg];
				}
			}

			return msg;
		}

		static Translator()
		{
			m_TranslationsEn.Add("Kein Alarm", "No alarm");
			m_TranslationsEn.Add("Neuer Plan", "New Plan");
			m_TranslationsEn.Add("Abschicken in", "Send in");
			m_TranslationsEn.Add("Neue Liste", "New List");
			m_TranslationsEn.Add("Fehler beim Importieren. Ein oderm ehrere Zeilen wurden nicht importiert.", "Error while importing.");

			m_TranslationsEn.Add("Bitte in den Einstellugnen die richtige Welt wählen und die Weltdaten laden.\nEinstellungen öffnen?", "Please set your world in the setting.\nOpen settings now?");
			m_TranslationsEn.Add("DS-Timer Erster Start", "DS-Timer first Start");

		}
	}
}
