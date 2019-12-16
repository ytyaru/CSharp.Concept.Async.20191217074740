using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
namespace Concept.Linq.Lesson0 {
    class Main
    {
        public async Task Run()
        {
            Console.WriteLine("Lesson0");
            Console.WriteLine(await GetHtml());
        }
        private async Task<string> GetHtml(string url="https://www.google.co.jp") {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }
    }
}
