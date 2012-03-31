using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DS_Timer.Gui
{
	public class DonateButton : Button
	{
		public override string Text
		{
			get
			{
				 return "";
			}
			set
			{
				base.Text = value;
			}
		}

		public DonateButton()
		{
			this.Image = global::DS_Timer.Properties.Resources.btn_donate_LG;
		}

		protected override void OnClick(EventArgs e)
		{
/*
<form action="https://www.paypal.com/cgi-bin/webscr" method="post">
<input type="hidden" name="cmd" value="_s-xclick">
<input type="hidden" name="hosted_button_id" value="XN2WYZSSMGQSJ">
<input type="image" src="https://www.paypal.com/de_DE/DE/i/btn/btn_donate_LG.gif" border="0" name="submit" alt="Jetzt einfach, schnell und sicher online bezahlen – mit PayPal.">
<img alt="" border="0" src="https://www.paypal.com/de_DE/i/scr/pixel.gif" width="1" height="1">
</form>
*/


			string url = "https://www.paypal.com/cgi-bin/webscr";

			string cmd = "_s-xclick";//"_donations";
			string hosted_button_id = "XN2WYZSSMGQSJ";
			/*
			string business = "my@paypalemail.com";  // your paypal email
			string description = "Donation";            // '%20' represents a space. remember HTML!
			string country = "AU";                  // AU, US, etc.
			string currency = "AUD";                 // AUD, USD, etc.
			*/

			url +=	"?cmd=" + cmd +
					"&hosted_button_id=" + hosted_button_id;

			/*
			url += "https://www.paypal.com/cgi-bin/webscr" +
				"?cmd=" + cmd +
				"&hosted_button_id=" + hosted_button_id +
				"&business=" + business +
				"&lc=" + country +
				"&item_name=" + description +
				"&currency_code=" + currency +
				"&bn=" + "PP%2dDonationsBF";
			*/
			System.Diagnostics.Process.Start(url);

			base.OnClick(e);
		}
	}
}
