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
        // Da bewegungen nur nach oben, unten, links und rechts möglich sind, sollte der Bot wissen was sich um ihn herum befindet und auf welchem untergrund er sich aktuell befindet.
        object left;
        object right;
        object behind;
        object inFront;
        object current;
        // Alle motoren innerhalöb des Bots Initialisieren
        Motor motorChainDriveLeft;
        Motor motorChainDriveRight;
        Motor motorGrapplerRotation;
        Motor motorGrapplerTilt;
        Motor motorGrapplerJoint1;
        Motor motorGrapplerJoint2;
        Motor motorGripperRotation;
        Motor motorGripper;
        

        public RescueBot(int posX, int posY)
        {
            this.positionX = posX;
            this.positionY = posY;
            Console.WriteLine("Rescue Bot generated at X:{0}, Y:{1}", this.positionX,this.positionY);

            // Alle motoren innerhalöb des Bots Initialisieren
            this.motorChainDriveLeft = new Motor(100,"ChainDriveLeft",false,0,0);
            this.motorChainDriveRight = new Motor(100,"ChainDriveRight",false,0,0);
            this.motorGrapplerRotation = new Motor(100,"GrapplerRotation",false,0,360);
            this.motorGrapplerTilt = new Motor(100,"GrapplerTilt",false,0,180);
            this.motorGrapplerJoint1 = new Motor(100,"GrapplerJoint1",false,-90,90);
            this.motorGrapplerJoint2 = new Motor(100,"GrapplerJoint2",false,-90,90);
            this.motorGripperRotation = new Motor(100,"GripperRotation",false,0,360);
            this.motorGripper = new Motor(100,"GrapplerTilt",false,0,100);
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
