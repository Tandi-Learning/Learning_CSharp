using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Async_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");
            GetContent();
            Console.WriteLine("Main End");
            Console.WriteLine(Environment.NewLine);
        }

        private static async void GetContent()
        {
            Console.WriteLine("GetContent() Start");
            var http = new HttpWrapper();
            var content = await http.GetUrlAsync("http://microsoft.com");
            Console.WriteLine(Environment.NewLine + content);
            Console.WriteLine("GetContent() End");
        }
    }

    public class HttpWrapper
    {
        public async Task<string> GetUrlAsync(string url)
        {
            Console.WriteLine("HttpWrapper.GetUrlAsync() Start");
            var httpClient = new HttpClient();
            var content = await httpClient.GetStringAsync("http://microsoft.com");
            Console.WriteLine("HttpWrapper.GetUrlAsync() End");
            return content;
        }
    }
}
