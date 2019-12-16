using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
namespace Concept.Linq.Lesson1 {
    class Main
    {
        public async Task Run()
        {
            Console.WriteLine("Lesson1");
            Console.WriteLine("WhenAny");
            await Task.WhenAny(new Task[] { Work1(), Work2() });
            Console.WriteLine("WhenAll");
            await Task.WhenAll(new Task[] { Work1(), Work2() });
        }
        private async Task Work1() { await Task.Delay(1000); Console.WriteLine("Work1 finished."); }
        private async Task Work2() { await Task.Delay(3000); Console.WriteLine("Work2 finished."); }
    }
}
