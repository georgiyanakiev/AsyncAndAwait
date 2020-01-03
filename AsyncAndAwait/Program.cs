using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace AsyncAndAwait
{
    public static class Program9
    {
        public static void Main()
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
