using System;
using System.Threading.Tasks;

namespace BOT_John
{
    class Program
    {
        public static async Task Main(string[] args)
            => await Startup.RunAsync(args);
    }
}
