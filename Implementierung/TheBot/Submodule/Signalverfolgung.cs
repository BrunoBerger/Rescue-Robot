using System;

namespace Implementierung
{
    public abstract class Antenna
    {
        public Antenna()
        {

        }
        

    }

    public class LeftAntenna : Antenna
    {
        public LeftAntenna()
        {
            Console.WriteLine("Left Antenna started!");
        }
    }
    public class RightAntenna : Antenna
    {
        public RightAntenna()
        {
            Console.WriteLine("Right Antenna started!");
        }
        public int[,] getSignal(Premises premises)
        {
            int[,] allmessages = new int[3,3];
            allmessages = premises.radioTowersSend();
            return allmessages;
        }
    }
    public class BacksideAntenna : Antenna
    {
        public BacksideAntenna()
        {
            Console.WriteLine("Backside Antenna started!");
        }
    }
}