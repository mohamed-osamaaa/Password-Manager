using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class EncryptionUtility
    {
        private static readonly string _allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly string _altChar = "48SZcApnbqJ0iT7R9DsYX5jeV6yt3mNfhIrdvGx2lQUKwCMoL1EagWHBuFkzOP";

        public static string Encrypt(string password)
        {
            var sb = new StringBuilder();
            foreach(var ch in password)
            {
                var charIndex = _allChar.IndexOf(ch);
                sb.Append(_altChar[charIndex]);
            }
            return sb.ToString();
        }
        public static string Decrypt(string password)
        {
            var sb = new StringBuilder();
            foreach (var ch in password)
            {
                var charIndex = _altChar.IndexOf(ch);
                sb.Append(_allChar[charIndex]);
            }
            return sb.ToString();
        }
    }
}
