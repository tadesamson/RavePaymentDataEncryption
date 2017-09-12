using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptionService.RavePaymentDataEncryption en = new EncryptionService.RavePaymentDataEncryption();
            string key = en.GetEncryptionKey("FLWSECK-4127f15e63c9098402dcc7891798fb0f-X");
            string data="{" +
                                                "\"PBFPubKey\":\"FLWPUBK-1cf610974690c2560cb4c36f4921244a-X\"," +
                                                "\"amount\":1000," +
                                                "\"device_fingerprint\":\"e42afa649d16fb67416186c6a3c942e9\"," +
                                                "\"txRef\":\"PAT-0.06208890843489279\"," +
                                                "\"IP\":\"197.210.173.93\"," +
                                                "\"email\":\"tdontop@qa.team\"," +
                                                "\"pin\":\"3310\"," +
                                                "\"suggested_auth\":\"PIN\"," +
                                                "\"expirymonth\":\"09\"," +
                                                "\"expiryyear\":\"19\"," +
                                                "\"cvv\":\"789\"," +
                                                "\"cardno\":\"5438898014560229\"" +
                                                "}";

            string cipher = en.EncryptData(key, data);
            string plaintext = en.DecryptData(cipher, key);
            Console.WriteLine(key);
            Console.ReadLine();

        }
    }
}
