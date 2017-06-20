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
            string key= en.GetEncryptionKey("FLWSECK-4127f15e63c9098402dcc7891798fb0f-X");
            string cipher = en.EncryptData(key, "{'data':'tade'}");
            Console.WriteLine(key);
            Console.ReadLine();

        }
    }
}
