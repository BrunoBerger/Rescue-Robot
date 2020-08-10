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

        public Motor(int speed, string name, bool state, int startP, int endP)
        {
            this.maxSpeed = speed;
            this.motorName = name;
            this.motorState = state;
            this.startPoint = startP;
            this.endPoint = endP;
            Console.WriteLine("Motor {0} added!", this.motorName);
            {
                
            }
        }
        public void getSignal()
        {

        }
        public void motorOff()
        {
            this.motorState = false;
        }
        public void motorOn()
        {
            this.motorState = true;
        }
    }

    public class RescueBot
    {   
        int positionX;
        int positionY;
        object undergrund;

        public RescueBot(int posX, int posY)
        {
            this.positionX = posX;
            this.positionY = posY;
            Console.WriteLine("Rescue Bot generated at X:{0}, Y:{1}", this.positionX,this.positionY);
        }

        
        public void detectUnderground()
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
            // Alles was auf dem Bot ist sollte die Position des Bots erben 
            // Initialisierung der Peripherie und des Greifers innhalb des RescueBot Consturctors?
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
            Premises premises = new Premises(22, 20);


            premises.generateMap();

        }
    }
}
