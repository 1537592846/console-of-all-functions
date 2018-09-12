using System;
using System.Net;

namespace console_of_all_functions.libraries.internet
{
    class Request
    {
        internal static void SiteAccess(string site)
        {
            if (!site.Contains("http"))
            {
                site = "http://" + site;
            }

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(site);
                request.Method = "GET";
                request.Timeout = 5000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine("The site returned a " + response.StatusDescription + " response");
            }
            catch
            {
                Console.WriteLine("Problems connecting with the site");
            }
        }
    }
}
