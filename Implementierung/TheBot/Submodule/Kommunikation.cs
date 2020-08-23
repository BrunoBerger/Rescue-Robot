using System;

namespace Implementierung
{
    public class Peripherie
    {
        
        public void turnOn()
        {

        }
        public void turnOff()
        {

        }
    }
    public class Camera : Peripherie
    {
        public Camera()
        {
            Console.WriteLine("Camera started!");
        }
        public void detectPerson()
        {
            Console.WriteLine("Person detected!");
        }    
    }

    public class Microphon : Peripherie
    {
        public Microphon()
        {
            Console.WriteLine("Microphon started!");
        }
        public void reciveMessage()
        {

        }
    }

    public class Loudspeaker : Peripherie
    {
        public Loudspeaker()
        {
            Console.WriteLine("Loudspeaker started!");
        }
        public void sendMessage()
        {
            Console.WriteLine("Is everything alright?");
        }
    }
}