using System;
using System.Threading.Tasks;

namespace Concept.Linq {
    class Program {
        static async Task Main() {
            await new Lesson0.Main().Run();
            await new Lesson1.Main().Run();
        }
    }
}
