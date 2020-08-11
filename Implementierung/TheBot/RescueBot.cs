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
        }
        public void getSignal()
        {

        }
        public string returnName()
        {
            return this.motorName;
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
        int startPositionX;
        int startPositionY;
        // Da bewegungen nur nach oben, unten, links und rechts möglich sind, sollte der Bot wissen was sich um ihn herum befindet und auf welchem untergrund er sich aktuell befindet.
        int maxTransportWeight = 200;

        object left;
        object right;
        object behind;
        object inFront;
        object current;
        // Alle motoren innerhalöb des Bots Initialisieren
        Motor motorChainDriveLeft;
        Motor motorChainDriveRight;
        Motor turbine;
        Motor rudder;

        

        public RescueBot(int posX, int posY)
        {
            this.positionX = posX;
            this.positionY = posY;
            this.startPositionX = posX;
            this.startPositionY = posY;
            Console.WriteLine("Rescue Bot generated at X:{0}, Y:{1}", this.positionX,this.positionY);

            // Motoren innerhalöb des Bauteils Initialisieren
            this.motorChainDriveLeft = new Motor(100,"ChainDriveLeft",false,0,0);
            this.motorChainDriveRight = new Motor(100,"ChainDriveRight",false,0,0);
            this.turbine = new Motor(100,"Turbine",false,0,0);
            this.rudder = new Motor(100,"Rudder",false,0,0);

            // Initilise Grappler
            Grappler grappler = new Grappler();
            Gripper gripper = new Gripper();
            
            // Initialisierung der Peripherie und des Greifers innhalb des RescueBot Consturctors?
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
        }

        public void updateSurroundings(object Underground, object Left, object Right, object Behind, object InFront)
        {
            this.current = Underground;
            this.left = Left;
            this.right = Right;
            this.behind = Behind;
            this.inFront = InFront;
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

            //Test
            Premises premises = new Premises(22, 20);
            premises.generateMap();
            
            object[,] map = premises.generateMap();
            
            RescueBot rescueBot = new RescueBot(premises.returnStartingPosition()[0],premises.returnStartingPosition()[1]);
            
        }
    }
}
