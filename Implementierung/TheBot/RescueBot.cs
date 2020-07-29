using System;

namespace Implementierung
{
    class RescueBot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lass wen retten");
            Greifer greifer = new Greifer();
            greifer.schliessen();
        }
    }
}
