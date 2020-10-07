using System;
using System.Security.Cryptography;
using System.Web.UI;
using nsoftware.IPWorksEncrypt;
using TwoFishExample.Model;

namespace TwoFishExample
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void BtnEncriptar_Click(object sender, EventArgs e)
		{
			var twofish = new TwoFish();
			var key = "7f9facc418f74439c5e9709832;0ab8a5:OCOdNSW1,q8SLIQz8i|8agmu¬s13Q7ZXyno/";
			twofish.TwoFishEncryption(TxtMessage.Text, key);
			TxtAreaEncriptado.Value = twofish.TwoFishEncryption(TxtMessage.Text, key);
		}

        protected void btnDesEncriptar_click(object sender, EventArgs e)
        {
			var twofish = new TwoFish();
			var key = "7f9facc418f74439c5e9709832;0ab8a5:OCOdNSW1,q8SLIQz8i|8agmu¬s13Q7ZXyno/";
			TxtAreaEncriptado.Value = twofish.TwoFishDecryption(TxtMessage.Text, key);
		}
    }
}