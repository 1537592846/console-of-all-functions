using System;
using System.IO;
using System.Text;

namespace console_of_all_functions.libraries.hacks
{
    class Hacks
    {
        internal static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        internal static void Wifi()
        {
            string createWifiFile = @"/c netsh wlan show profiles>wifiNames.txt";
            System.Diagnostics.Process.Start("CMD.exe", createWifiFile);
            var lines = File.ReadAllLines("wifiNames.txt", Encoding.UTF8);
            var output = File.OpenText("wifiPasswords.txt");

            foreach(var line in lines)
            {
                string getWifiPassword = @"/c netsh wlan show profile "+line.Split(':')[1]+" key=clear & find \"*key*\">wifiInfo.txt";
                System.Diagnostics.Process.Start("CMD.exe", getWifiPassword);
                var info = File.ReadAllLines("wifiInfo.txt", Encoding.UTF8);
            }
        }
    }
}
