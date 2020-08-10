using System;

namespace Implementierung
{
    public class Motor
    {
        int maxSpeed;
        string motorName;
        bool motorState;        // True = on   False = off
        int startPoint;
        int endPoint;

        public void getSignal()
        {

        }
        public void motorOff()
        {

        }
        public void motorOn()
        {

        }
    }

    class RescueBot
    {
        int locationX;
        int locationY;

        public void detectLocation()
        {
            
        }
        public void signalRequest()
        {
            
        }
        public void getSignal()
        {
            
        }
        public void trackSignal()
        {
            
        }
        public void driveForward()
        {
            
        }
        public void driveBackward()
        {
            
        }
        public void driveLeft()
        {
            
        }
        public void driveRight()
        {
            
        }
        public void swimForward()
        {
            
        }
        public void swimBackward()
        {
            
        }
        public void swimLeft()
        {
            
        }
        
        public void swimRight()
        {
            
        }
        
        public void stop()
        {
            
        }
        
        public void measureObstacle()
        {
            
        }
        
        public void grip()
        {
            
        }
        
        public void collectObstacle()
        {
            
        }     

        static void Main(string[] args)
        {
            Console.WriteLine("Lass wen retten");

            // Greifer Subsystem
            Grappler grappler = new Grappler();
            Gripper gripper = new Gripper();
            ForceTransducer forceTransducer = new ForceTransducer();
            Support support = new Support();
            BoxCover boxCover = new BoxCover();

            // Kommunikation-Subsystem:
            Camera camera = new Camera();
            Microphon microphon = new Microphon();
            Loudspeaker loudspeaker = new Loudspeaker();

            // Navigation-Subsystem:
            Navigation navigation = new Navigation();

            //Signalverfolgung-Subsystem:
            LeftAntenna leftAntenna = new LeftAntenna();
            RightAntenna rightAntenna = new RightAntenna();
            BacksideAntenna backsideAntenna = new BacksideAntenna();

            //Objektbergung-Subsystem:
            LIDARSensor lidarSensor = new LIDARSensor();
            GeigerCounter geigerCounter = new GeigerCounter();
            
            //Test
            Premises premises = new Premises(20,20);


            premises.generateMap();
        }
    }
}
