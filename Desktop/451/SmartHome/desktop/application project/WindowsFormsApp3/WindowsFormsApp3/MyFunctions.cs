using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp3
{
    public class MyFunctions
    {
        public static string Encrypt(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException("plainText");
            var data = Encoding.Unicode.GetBytes(plainText);
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.LocalMachine);
            return Convert.ToBase64String(encrypted);
        }
        public static string Decrypt(string cipher)
        {
            if (cipher == null) throw new ArgumentNullException("cipher");
            byte[] data = Convert.FromBase64String(cipher);
            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.LocalMachine);
            return Encoding.Unicode.GetString(decrypted);
        }
    }
}
