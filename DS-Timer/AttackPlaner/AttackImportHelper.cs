using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using DS_Timer.AttackPlaner.Import;
using System.Globalization;
using DS_Timer.World;
using System.Windows.Forms;
using DS_Timer.Localization;

namespace DS_Timer.AttackPlaner
{
	public class AttackImportHelper
	{


		public static string NormalizeLocation(string locString)
		{
			locString = Regex.Replace(locString, @"[\|/\\;,]", "|");

			Match match = Regex.Match(locString, @"[0-9]+\|[0-9]+");
			return match.Value;


			// If nothing found remove crap and hope it fits ;)
			//return Regex.Replace(locString, @"[^0-9|\(\)]", "");
		}

		public static Location ParseLocation(string locString)
		{
			locString = NormalizeLocation(locString);
			string[] token = locString.Split('|');

			try
			{
				return new Location(int.Parse(token[0]), int.Parse(token[1]));
			}
			catch (Exception)
			{
				return new Location();
			}
		}

		public List<AttackOrder> ImportFromDSTimer(string orders)
		{
			/*
	Verbleibend	Startdorf	Angreifer	Zieldorf	Verteidiger	Abschickzeit	Ankunft	Langsamste Einheit	Notiz
	00:00:00	(564|746) A-L-U-C-A-R-Ds Dorf	A-L-U-C-A-R-D	(269|376) [001]	G-PowerV10	14.10.2011 03:08:26.000	25.10.2011 23:03:53.000	Bogen [36 min / Feld]	
	00:00:00	(564|746) A-L-U-C-A-R-Ds Dorf	A-L-U-C-A-R-D	(269|376) [001]	G-PowerV10	14.10.2011 03:08:26.000	25.10.2011 23:03:53.000	Speer [36 min / Feld]	
	00:00:00	(564|746) A-L-U-C-A-R-Ds Dorf	A-L-U-C-A-R-D	(269|376) [001]	G-PowerV10	19.10.2011 09:19:44.000	25.10.2011 23:03:53.000	Pala [20 min / Feld]	
			*/

			List<AttackOrder> result = new List<AttackOrder>();
			string[] lines = orders.Split('\n');

			bool error = false;
			for (int i = 0; i < lines.Length; i++)
			{
				try
				{
					string m = lines[i];
					string[] line = m.Split('\t');
					AttackOrder newOrder = new AttackOrder();
					newOrder.Comment = line[9];
					newOrder.StartLocation = ParseLocation(line[2]);
					newOrder.TargetLocation = ParseLocation(line[4]);
					newOrder.ArrivleTime = DateTime.Parse(line[7]);
					newOrder.Unit = Unit.Parse(line[8].Split(' ')[0]);
					result.Add(newOrder);
				}
				catch (Exception)
				{
					error = true;
				}
			}
			if (error)
				MessageBox.Show(Translator.Translate("Fehler beim Importieren. Ein oderm ehrere Zeilen wurden nicht importiert."));






			return result;
		}

		public List<AttackOrder> ImportFromDSReal(string order)
		{
			/*
[1]
Art	Startdorf	Angreifer	Zieldorf	Verteidiger	Abschickzeit	Ankunft	Restzeit	Aktionen
	-001- Dogville (509|746)	Niondir 	-028- South Park (517|750)	Niondir 	27.02 - 13:27:04	27.02 - 18:40:07	00:00:00	
	-020- Hill Valley (518|743)	Niondir 	-028- South Park (517|750)	Niondir 	27.02 - 14:32:38	27.02 - 18:40:07	00:00:00	
	-008- Springfield (513|754)	Niondir 	-028- South Park (517|750)	Niondir 	27.02 - 15:22:08	27.02 - 18:40:07	00:00:00	
	-001- Dogville (509|746)	Niondir 	-028- South Park (517|750)	Niondir 	27.02 - 15:23:21	27.02 - 18:40:07	00:00:00	
[1] Alle markieren
			 * */
			List<AttackOrder> result = new List<AttackOrder>();

			string regExVillage = @"(.)+";
			string regExPlayer = @"(.)+";
			string regExDateTime = @"[0-9]{2}\.[0-9]{2} - [0-9]{2}:[0-9]{2}:[0-9]{2}";
			string regExRemainingTime = @"[0-9]{2}:[0-9]{2}:[0-9]{2}";



			string regEx = String.Format(@"^(\t)?{0}\t{1}\t{0}\t{1}\t{2}\t{2}\t{3}(\t)?$", regExVillage, regExPlayer, regExDateTime, regExRemainingTime);
			MatchCollection matches = Regex.Matches(order, regEx, RegexOptions.Multiline);

			// Läuft! Jetzt noch die einzelnen Zeilen auseinander nehmen
			foreach (Match match in matches)
			{
				string[] token = match.Value.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

				AttackOrder newOrder = new AttackOrder();
				newOrder.StartLocation = ParseLocation(token[0]);
				newOrder.TargetLocation = ParseLocation(token[2]);

				// Parse: "15.03 - 08:01:00"
				newOrder.ArrivleTime = DateTime.ParseExact(token[5], @"dd.MM - HH:mm:ss", new CultureInfo("de-DE", true));
				newOrder.ArrivleTime.AddMilliseconds(-newOrder.ArrivleTime.Millisecond);
				// Arrivle
				// Check send time
				DateTime sendTime = DateTime.ParseExact(token[4], @"dd.MM - HH:mm:ss", new CultureInfo("de-DE", true));
				sendTime.AddMilliseconds(-sendTime.Millisecond);
				newOrder.SetUnitFromSendTime(sendTime);

				// newOrder.ArrivleTime = TimeSyncHandler.Now;
				result.Add(newOrder);
			}

			return result;
		}

		public List<AttackOrder> ImportFromDsMap(string orders)
		{
			/*
DSMap:
am 20.03.2011 15:23:15:666 von (548|616) auf (589|591) mit Adelsgeschlecht
am 20.03.2011 23:42:07:629 von (553|607) auf (589|591) mit Katapult
am 21.03.2011 01:39:56:473 von (556|604) auf (589|591) mit Rammbock
am 21.03.2011 12:05:41:875 von (550|611) auf (589|591) mit Paladin
am 21.03.2011 13:54:21:415 von (562|604) auf (589|591) mit Schwere Kavallerie
am 21.03.2011 14:51:02:590 von (565|604) auf (589|591) mit Berittener Bogenschütze
am 21.03.2011 15:04:23:421 von (577|599) auf (589|591) mit Bogenschütze
am 21.03.2011 15:22:07:339 von (568|603) auf (589|591) mit Leichte Kavallerie
am 21.03.2011 16:38:02:295 von (582|597) auf (589|591) mit Axtkämpfer
am 21.03.2011 16:38:46:321 von (573|600) auf (589|591) mit Späher
am 21.03.2011 17:50:39:117 von (586|594) auf (589|591) mit Schwertkämpfer
am 21.03.2011 18:58:32:052 von (588|592) auf (589|591) mit Speerträger
 */
			List<AttackOrder> result = new List<AttackOrder>();

			string date = @"[0-9]{2}\.[0-9]{2}\.[0-9]{4}";
			string regex = @"^am (.+) von (.+) auf (.+) mit (.+)$";
			MatchCollection matches = Regex.Matches(orders, regex, RegexOptions.Multiline);

			foreach (Match m in matches)
			{
				AttackOrder newOrder = new AttackOrder();
				newOrder.StartLocation = ParseLocation(m.Groups[2].Value);
				newOrder.TargetLocation = ParseLocation(m.Groups[3].Value);
				newOrder.Unit = Unit.Parse(m.Groups[4].Value);

				// Einheit setzten!

				// 15.03.2011 01:34:05:468
				newOrder.SendTime = DateTime.ParseExact(m.Groups[1].Value, @"dd.MM.yyyy HH:mm:ss:fff", new CultureInfo("de-DE", true));

				result.Add(newOrder);
			}

			//string[] lines = orders.Split('\n');

			return result;
		}

		internal List<AttackOrder> ImportFromWorkbench(string orders)
		{
			/*
		 
(Clean-Off)	TaMiDoKi	Westside [21] (276|529)	Ramme	TaMiDoKi	Westside [11] (282|529)	30.03.11 22:02:57.823	31.03.11 01:02:57.822
(Clean-Off)	TaMiDoKi	Westside [21] (276|529)	Späher	TaMiDoKi	Westside [11] (282|529)	31.03.11 00:08:57.260	31.03.11 01:02:57.259
	0		 1				2						3		4				5					6							7		 


			 */
			// .*[village]136|505[/village] mit [img]http://de63.die-staemme.de/graphic/unit/unit_ram.png[/img] .*[village]207|546[/village] startet am [color=#ff0e0e]26.03.11 um 16:00:22.[size=8]076[/size][/color] und kommt am [color=#2eb92e]28.03.11 um 10:00:00.[size=8]123[/size][/color] an ([url="http://de63.die-staemme.de/game.php?village=126368&screen=place&mode=command&target=89648"]Versammlungsplatz[/url])


			List<AttackOrder> result = new List<AttackOrder>();

			string[] lines = orders.Split('\n');

			foreach (string m in lines)
			{
				string[] line = m.Split('\t');
				AttackOrder newOrder = new AttackOrder();
				newOrder.Comment = line[0];
				newOrder.StartLocation = ParseLocation(line[2]);
				newOrder.TargetLocation = ParseLocation(line[5]);
				newOrder.ArrivleTime = DateTime.Parse(line[7]);
				newOrder.Unit = Unit.Parse(line[3]);
				result.Add(newOrder);
			}


			return result;
		}

		public List<VillageInfo> ImportVillages(string input)
		{
			List<VillageInfo> villages = new List<VillageInfo>();
			string pattern = @"[0-9]{1,3}\|[0-9]{1,3}";
			MatchCollection matches = Regex.Matches(input, pattern);
			foreach (Match m in matches)
			{
				Location loc = AttackImportHelper.ParseLocation(m.Value);
				VillageInfo village = WorldHandler.VillageFile.FindByLoc(loc);
				if (village != VillageInfo.NullVillage)
				{
					villages.Add(village);
				}
			}
			return villages;

		}
	}
}