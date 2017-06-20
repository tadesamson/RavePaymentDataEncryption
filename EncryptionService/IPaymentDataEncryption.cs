using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionService
{
    public interface IPaymentDataEncryption
    {
        string GetEncryptionKey(string secretKey);
        string EncryptData(string encryptionKey, String data);
        string DecryptData(string encryptedData,string encryptionKey);
    }
}
