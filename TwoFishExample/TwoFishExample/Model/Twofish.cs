using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TwoFishExample.Model
{
    public class TwoFish
    {

        public string TwoFishEncryption(string plain, string key)
        {

            BCEngine bcEngine = new BCEngine(new TwofishEngine(), Encoding.ASCII);
            bcEngine.SetPadding(new Pkcs7Padding());
            return bcEngine.Encrypt(plain, key);
        }

        public string TwoFishDecryption(string cipher, string key)
        {
            BCEngine bcEngine = new BCEngine(new TwofishEngine(), Encoding.ASCII);
            bcEngine.SetPadding(new Pkcs7Padding());
            return bcEngine.Decrypt(cipher, key);
        }
    }
}