using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    internal class Program
    {
        private static readonly Dictionary<string, string> _passwordEntries = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            ReadPasswords();
            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. List all passwords");
                Console.WriteLine("2. Add/Change password");
                Console.WriteLine("3. Get password");
                Console.WriteLine("4. Delete password");
                var selectedOption = Console.ReadLine();
                if (selectedOption == "1")
                    ListAllPasswords();
                else if (selectedOption == "2")
                    AddOrChangePassword();
                else if (selectedOption == "3")
                    GetPassword();
                else if (selectedOption == "4")
                    DeletePassword();
                else
                    Console.WriteLine("Invalid option");
                Console.WriteLine("-----------------------------------------");
            }
        }
        private static void ListAllPasswords()
        {
            if (File.Exists("passwords.txt"))
            {
                foreach (var entry in _passwordEntries)
                    Console.WriteLine($"{entry.Key}={entry.Value}");
            }
            else
                Console.WriteLine("No exists passwords");
        }
        private static void AddOrChangePassword()
        {
            Console.Write("Please enter website/app name: ");
            var appName = Console.ReadLine();
            Console.Write("Please enter your password: ");
            var password = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName))
                _passwordEntries[appName] = password;
            else
                _passwordEntries.Add(appName, password);
            SavePasswords();
        }

        private static void GetPassword()
        {
            Console.Write("Please enter website/app name: ");
            var appName = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName))
                Console.WriteLine($"Your password is: {_passwordEntries[appName]}");
            else
                Console.WriteLine("Password not found");
        }
        private static void DeletePassword()
        {
            Console.Write("Please enter website/app name: ");
            var appName = Console.ReadLine();
            if (_passwordEntries.ContainsKey(appName))
            {
                _passwordEntries.Remove(appName);
                SavePasswords();
            }
            else
                Console.WriteLine("Password not found");
        }



        private static void ReadPasswords()
        {
            if (File.Exists("passwords.txt"))
            {
                var passwordLines = File.ReadAllLines("passwords.txt");
                foreach (var line in passwordLines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var equalIndex = line.IndexOf('=');
                        var appName = line.Substring(0, equalIndex);
                        var password = line.Substring(equalIndex + 1);
                        _passwordEntries.Add(appName,EncryptionUtility.Decrypt(password));
                    }
                }
            }
        }
        private static void SavePasswords()
        {
            var sb = new StringBuilder();
            foreach (var entry in _passwordEntries)
                sb.AppendLine($"{entry.Key}={EncryptionUtility.Encrypt(entry.Value)}");
            File.WriteAllText("passwords.txt", sb.ToString());
        }
    }
}
