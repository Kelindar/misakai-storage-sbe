using System;
using Misakai.Storage.Sbe.Examples.generated_stub;
using Misakai.Storage.Sbe.Examples.Otf;

namespace Misakai.Storage.Sbe.Examples
{
    class Program
    {
        public static void Main()
        {
            ExampleUsingGeneratedStub.Main();

            OtfExample.Main();

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
