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

        }    
    }

    public class Microphon : Peripherie
    {
        public Microphon()
        {
            Console.WriteLine("Microphon started!");
        }
        public void sendMessage()
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

        }
    }
}