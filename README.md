# Rave Payment Data Encryption Snippets
code nuggets for generating rave encryption key, encrypting and decrypting payment data.

# Description
RavePaymentDataEncryption is a .net library written to generate rave encryption key as well as proceeding with encrypting your payment data
using standard .net Cryptographic algorithms.

# Usage
to use the RavePaymentDataEncryption, simply create an instance and call the GetEncryptionKey method. 
the return key can be use to initiate the EncryptData method.
NB: in other to get a success response from rave, comply to using Rave payload, payload paramters or values (test payload) sometimes change. So, be up to date
    to ensure you're encypting the correct payload format.

```
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
            ```

the generated long string cipher can be used as your client parameter: 

```
{
  "PBFPubKey": "FLWPUBK-1cf610974690c2560cb4c36f4921244a-X",
  "client": cipher
  "alg": "3DES-24"
}
```

this is the response body sent to rave.
HAPPY CODING..
