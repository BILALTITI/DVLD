using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Security.Cryptography;

namespace DVLD
{
    internal static class clsGloabalcs
    {
        public static User CurrentUser;
        private static string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
        // string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";

        private static string valueUserName = "User Name";
        private static string valuePass = "Passwords";

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {


            try
            {

                string UserNameData = Username;
                string PasswordData = Password;

                Registry.SetValue(keyPath, valueUserName, UserNameData, RegistryValueKind.String);
                Registry.SetValue(keyPath, valuePass, PasswordData, RegistryValueKind.String);
                //this will get the current project directory folder.
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {

            try
            {
                string _UerName = Registry.GetValue(keyPath, valueUserName, null) as string;
                string _Password = Registry.GetValue(keyPath, valuePass, null) as string;

                if (_UerName != null && _Password != null)
                {
                    Username = _UerName;
                    Password = _Password;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static void SaveToEventLog(string Message, EventLogEntryType LogTybe, string SourceName = "DVLD.App")
        {
            // Specify the source name for the event log


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");

            }


            // Log an information event
            EventLog.WriteEntry(SourceName, Message, LogTybe);

        }
        public static string ComputeHash(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}

