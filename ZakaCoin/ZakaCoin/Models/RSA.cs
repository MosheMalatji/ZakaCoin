using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZakaCoin.Models
{
    public static class RSA
    {

        public static string Sign(string PrivKey, string msgToSign)
        {
            var secret = Network.Main.CreateBitcoinSecret(PrivKey);
            var signature = secret.PrivateKey.SignMessage(msgToSign);
            //var bol = pkh.VerifyMessage(msgToSIgn,signature);

            var v = secret.PubKey.VerifyMessage(msgToSign, signature);
            return signature;
    }
}
}
