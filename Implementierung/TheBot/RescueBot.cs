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
        int maxTransportWeight = 200;
        double currentLoad = 0;
        // Bot sollte wissen was sich um ihn herum befindet und auf welchem untergrund er sich aktuell befindet.
        
        Ground left;
        Ground right;
        Ground behind;
        Ground inFront;
        Ground current;
        
        Motor motorChainDriveLeft;
        Motor motorChainDriveRight;
        Motor turbine;
        Motor rudder;

        Antenna leftAntenna;
        Antenna rightAntenna;
        Antenna backsideAntenna;

        Grappler grappler;
        Support support;

        CapacitySensor capacitySensor;

        LIDARSensor lidar;
        GeigerCounter geiger;
        Camera camera;
        Microphon microphon;
        Loudspeaker loudspeaker;

        Navigation navigation;
        BoxCover boxCover;
        Premises premises;
        
        // Der bot sollte noch eine Eigene Karte haben die er zur laufzeit erstellt um den weg zurück zu finden.
        public RescueBot(int posX, int posY, Premises premises)
        {
            
            this.premises = premises;

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

            // Initilise Grappler and support
            this.grappler = new Grappler();
            this.support = new Support();
            
            

            this.currentLoad = 0;

            this.boxCover = new BoxCover();

            // Kommunikation-Subsystem:
            this.camera = new Camera();
            this.microphon = new Microphon();
            this.loudspeaker = new Loudspeaker();
            
            this.capacitySensor = new CapacitySensor();

            //Objektbergung-Subsystem:
            this.lidar = new LIDARSensor();
            this.geiger = new GeigerCounter();

            // Navigation-Subsystem:
            this.navigation = new Navigation();

            //Signalverfolgung-Subsystem:
            this.leftAntenna = new LeftAntenna();
            this.rightAntenna = new RightAntenna();
            this.backsideAntenna = new BacksideAntenna();

            
        }

        public void updateSurroundings()
        {
            // muss mit Lidar geupdated werden
            Ground[] sourroundings = new Ground[5];
            sourroundings = lidar.detectSourroundings(this.positionX,this.positionY,premises);
            this.current = sourroundings[0];
            this.left = sourroundings[1];
            this.right = sourroundings[2];
            this.behind = sourroundings[3];
            this.inFront = sourroundings[4];


            // Debug Print 
            // was ist um mich herum....
            foreach (Ground X in sourroundings)
            {
                Console.WriteLine("{0}, trav:{1}, Type:{2}",X,X.returnTraversable(),X.GetType());
            }

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

        // Fahren auslagern in eigene Methode -> Effektiver
        public void driveForward()
        // da sich der bot nicht dreht, ist vorne immer norden auf der karte
        // Nicht mit Type of sondern über den sensor! das gilt für alle arten der bewegung!
        {
            if (inFront.returnTraversable())
            {
                positionY --;
            }
            else
            {
                Console.WriteLine("Bot cannot go forward!");
            }
        }
        public void driveBackward()
        // da sich der bot nicht dreht, ist hinten immer süden auf der karte
        {
            if (behind.returnTraversable())
            { 
                positionY ++;
            }
            else
            {
                Console.WriteLine("Bot cannot go backward!");
            }
        }
        public void driveLeft()
        // da sich der bot nicht dreht, ist links immer westen auf der karte
        {
            if (left.returnTraversable())
            {
                positionX --;
            }
            else
            {
                Console.WriteLine("Bot cannot go left!");
            }
        }
        public void driveRight()
        // da sich der bot nicht dreht, ist rechts immer osten auf der karte
        {
            if (right.returnTraversable())
            {
                positionX ++;
            }
            else
            {
                Console.WriteLine("Bot cannot go right!");
            }
        }
        public void swimForward()
        // da sich der bot nicht dreht, ist vorne immer norden auf der karte
        {
            
        }
        public void swimBackward()
        // da sich der bot nicht dreht, ist hinten immer süden auf der karte
        {
            
        }
        public void swimLeft()
        // da sich der bot nicht dreht, ist links immer westen auf der karte
        {
            
        }
        
        public void swimRight()
        // da sich der bot nicht dreht, ist rechts immer osten auf der karte
        {
            
        }
        
        public void stop()
        {
            
        }
        
        public void measureAndCollectObstacle(RadioactiveObstacle obstacle, double maxWeight, double maxSize)
        {   
            // Per Lidar die größe des Objektes ermitteln
            // wenn Größe passend, dann
            // Greifer zum Objekt bewegen
            // Strahlung messen
            // wenn strahlung größer, dann
            // Gripper schließen
            // Gewicht des objektes abfragen über force Tranducer
            // Entscheiden ob es zu schwer/zu groß ist oder nicht
            // rückgabe wert true wenn das objekt bewegt werden kann || False wenn nicht
            
            double size = lidar.determineSize(obstacle);
            if (size <= maxSize)
            {
                support.extend();
                grappler.openGripper();
                grappler.move_to_target_position(obstacle.returnPosX(),obstacle.returnPosY());
                double radiation = geiger.measureRadioactivity(obstacle);
                if (radiation >= 10)
                {
                    grappler.closeGripper();
                    double weight = grappler.measureWeight(obstacle);
                    if (weight <= maxWeight)
                    {
                        if ((this.currentLoad + weight) <= maxTransportWeight)
                        {
                            collectObstacle(weight);
                        }
                        else
                        {
                            Console.WriteLine("Rescue bot is Full");
                        }
                    }
                }
            }
            support.retract();
        }
        
        public void collectObstacle(double weight)
        {
            // box öffnen
            // geschlossenen greifer über die box bewegen
            // greifer öffnen
            // arm wieder in die ausgangsposition
            // box schließen
            boxCover.openCover();
            grappler.move_towards_box_pos();
            grappler.openGripper();
            this.currentLoad += weight;
            grappler.move_to_park_position();
            boxCover.closeCover();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lass wen retten");

            //Test
            Premises premises = new Premises(22, 20);
            
            
            object[,] map = premises.generateMap();
            
            RescueBot rescueBot = new RescueBot(premises.returnStartingPosition()[0],premises.returnStartingPosition()[1], premises);
            // Start navigation oder so
            
            // Bot ground movement Test // --> Works!!!
            /*
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveForward();
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveRight();
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveForward();
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveForward();
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveForward();
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveForward();
            */

            // TODO: 
            // Navigations algorithmus                                  
            // Automatisches aufsammeln von passenden gegenständen                  
            // wenn sie sich links, rechts, vor oder hinter dem fahrzeug befinden    
            // entfernen der gegenstände auf der Karte                              DONE
        }
    }
}
