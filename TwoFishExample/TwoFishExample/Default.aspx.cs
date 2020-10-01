using System;
using System.Security.Cryptography;
using System.Web.UI;
using nsoftware.IPWorksEncrypt;
using Twofish = ManyMonkeys.Cryptography.Twofish;


namespace TwoFishExample
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void BtnEncriptar_Click(object sender, EventArgs e)
		{
            Encrypt(TxtMessage.Text);
		}

        protected void btnDesEncriptar_click(object sender, EventArgs e)
        {
            Descrypt(TxtMessage.Text);
        }

        public void Encrypt(string cadena)
        {
            Twofish fish = new Twofish();
            fish.Mode = CipherMode.ECB;
            var ms = new System.IO.MemoryStream();

            byte[] Key = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            byte[] dummy = { };

            //create Twofish Encryptor from this instance
            ICryptoTransform encrypt = fish.CreateEncryptor(Key, dummy); // we use the plainText as the IV as in ECB mode the IV is not used

            using (var cryptostream = new CryptoStream(ms, encrypt, CryptoStreamMode.Write))
            {
                byte[] plainText = GetBytes(cadena);

                //write out Twofish encrypted stream
                cryptostream.Write(plainText, 0, plainText.Length);
            }
            byte[] bytOut = ms.ToArray();
            TxtAreaEncriptado.InnerText = GetString(bytOut);
        }

        public void Descrypt(string cadena)
        {
            Twofish fish = new Twofish();
            fish.Mode = CipherMode.ECB;
            byte[] Key = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            byte[] plainText = GetBytes(cadena);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            //create Twofish Decryptor from our twofish instance
            ICryptoTransform decrypt = fish.CreateDecryptor(Key, plainText);

            using (var cryptostream = new CryptoStream(ms, decrypt, CryptoStreamMode.Write))
            {
                byte[] bytOut = ms.ToArray();
                cryptostream.Write(bytOut, 0, bytOut.Length);
            }
            byte[] bytOutD = ms.GetBuffer();
            TxtAreaEncriptado.InnerText = GetString(bytOutD);
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }


    }
}