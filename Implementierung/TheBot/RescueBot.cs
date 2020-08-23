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
        public bool returnState()
        {
            return this.motorState;
        }
        public string returnName()
        {
            return this.motorName;
        }
        public void motorOff()
        {
            Console.WriteLine("Turning Motor {0} off!", this.motorName);
            this.motorState = false;
        }
        public void motorOn()
        {
            Console.WriteLine("Turning Motor {0} on!", this.motorName);
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

        LeftAntenna leftAntenna;
        RightAntenna rightAntenna;
        BacksideAntenna backsideAntenna;

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
            this.rudder = new Motor(100,"Rudder",false,0,100);

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

        public int returnXpos()
        {
            return this.positionX;
        }
        public int returnYpos()
        {
            return this.positionY;
        }
        public void updateSurroundings()
        {
            // muss mit Lidar geupdated werden
            Ground[] sourroundings = new Ground[5];
            sourroundings = lidar.detectSourroundings(this.positionX,this.positionY,this.premises);
            this.current = sourroundings[0];
            this.left = sourroundings[1];
            this.right = sourroundings[2];
            this.behind = sourroundings[3];
            this.inFront = sourroundings[4];


            // Debug Print
            // was ist um mich herum....
            if (this.current.GetType() == typeof(Water) && turbine.returnState() == false)
            {
                turbine.motorOn();
                motorChainDriveRight.motorOff();
                motorChainDriveLeft.motorOff();
            }
            else if(this.current.GetType() == typeof(StrongGround) && motorChainDriveLeft.returnState() == false && motorChainDriveRight.returnState() == false)
            {
                motorChainDriveRight.motorOn();
                motorChainDriveLeft.motorOn();
                turbine.motorOff();
            }

            foreach (Ground X in sourroundings)
            {
                //Console.WriteLine("{0}, trav:{1}, Type:{2}",X,X.returnTraversable(),X.GetType());
                if (X.GetType() == typeof(RadioactiveObstacle))
                {
                    Console.WriteLine("Found Radioactive Object at X: {0} and Y: {1}!", X.positionX, X.positionY);
                    measureAndCollectObstacle((RadioactiveObstacle)X,100, 100);
                }
                else if(X.GetType() == typeof(Person))
                {
                    camera.detectPerson();
                    Console.WriteLine("Found a Person at X: {0} Y: {1}!!", X.positionX, X.positionY);
                    loudspeaker.sendMessage();
                    Console.WriteLine("Stopping the Program. Collected {0}Kg Radioactive Material!", this.currentLoad);

                    // Programm beenden wenn die Person gefunden wurde!
                    Environment.Exit(1);
                }
            }
        }

        public void signalRequest()
        {
            
        }

        public int[,] getSignal()
        {
            int[,] message = new int[3,3];
            // message ={{ID,posx,posy},{ID,posx,posy},{ID,posx,posy}}
            message = rightAntenna.getSignal(this.premises);
            
            // das signal muss durch die antennen empfangen werden
            // Der bot soll zu dem Funkturm Fahren zu dem die distanz am geringsten ist.
            // Die funktürme müssen das funksignal mit der ID und den Koordinaten versenden
            // Ist der Bot direkt neben einem funkturm soll er diesen Ignorieren und dann wieder zum nächsten fahren!
            // Sind hindernisse im Weg, soll der bot diese umfahren
            // befinden sich radioaktive hindernisse auf dem weg soll der bot diese aufsammeln wenn sie den anforderungen entsprechen.
            // die getSignal() Methode soll die Koordinaten des Funkturms Zurück geben welcher angesteuert wird.
            // die calcDist() Methode wird verwendet um die entfernung zu den einzelnen Funktürmen zu berechnen
            return message;
        }
        public void trackSignal()
        {

        }


        // nur zum testen!!!!
        public int[] coordsToClosest(int[,] message)
        {
            int[] coords = new int[3];

            double dist1 = calcDist(message[0,1],message[0,2]);
            double dist2 = calcDist(message[1,1],message[1,2]);
            double dist3 = calcDist(message[2,1],message[2,2]);

            double min = Math.Min(Math.Min(dist1,dist2),dist3);

            if(min == dist1)
            {
                coords[0] = message[0,0];
                coords[1] = message[0,1];
                coords[2] = message[0,2];
            }
            else if(min == dist2)
            {
                coords[0] = message[1,0];
                coords[1] = message[1,1];
                coords[2] = message[1,2];
            }
            else if(min == dist3)
            {
                coords[0] = message[2,0];
                coords[1] = message[2,1];
                coords[2] = message[2,2];
            }
            return coords;
        }



        public double calcDist(int radioPosX, int radioPosY)
        {
            int difX = this.positionX - radioPosX;
            int difY = this.positionY - radioPosY;
            if (difX < 0)
            {
                difX = difX *(-1);
            }
            if (difY < 0)
            {
                difY = difY *(-1);
            }
            double dist = Math.Sqrt(Math.Pow(difX,2) + Math.Pow(difY,2));
            if(dist == 1)
            {
                // wenn der Bot direkt an einem Turm Steht ignoriert er diesen indem die Distanz künstlich auf 100 gesetzt wird
                dist = 100;
            }
            return dist;
        }

        public void startNavigation(RescueBot rescueBot)
        {
            int[] coords = new int[3];
            coords = coordsToClosest(getSignal());

            int destX = coords[1];
            int destY = coords[2];
            // destination muss aus getsignal und calc distance hervorgehen
            navigation.startNavigation(rescueBot,destX,destY);
            

            // Nachdem der erste Funkturm erreicht wurde zum zweiten navigieren
            coords = coordsToClosest(getSignal());
            destX = coords[1];
            destY = coords[2];
            navigation.startNavigation(rescueBot,destX,destY);
                            
            // Nachdem der zweite erreicht wurde zum dritten fahren
            coords = coordsToClosest(getSignal());
            destX = coords[1];
            destY = coords[2];
            navigation.startNavigation(rescueBot,destX,destY);            
        }

        // Fahren auslagern in eigene Methode -> Effektiver
        public bool driveForward()
        // da sich der bot nicht dreht, ist vorne immer norden auf der karte
        // Nicht mit Type of sondern über den sensor! das gilt für alle arten der bewegung!
        {
            if (inFront.returnTraversable())
            {
                this.positionY --;
                return true;
            }
            else
            {
                Console.WriteLine("Bot cannot go forward!");
                return false;
            }
        }
        public bool driveBackward()
        // da sich der bot nicht dreht, ist hinten immer süden auf der karte
        {
            if (behind.returnTraversable())
            {
                this.positionY ++;
                return true;
            }
            else
            {
                Console.WriteLine("Bot cannot go backward!");
                return false;
            }
        }
        public bool driveLeft()
        // da sich der bot nicht dreht, ist links immer westen auf der karte
        {
            if (left.returnTraversable())
            {
                this.positionX --;
                return true;          
            }
            else
            {
                Console.WriteLine("Bot cannot go left!");
                return false;
            }
        }
        public bool driveRight()
        // da sich der bot nicht dreht, ist rechts immer osten auf der karte
        {
            if (right.returnTraversable())
            {
                this.positionX ++;
                return true;
            }
            else
            {
                Console.WriteLine("Bot cannot go right!");
                return false;
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
                            Console.WriteLine("RescueBot Load = {0}", this.currentLoad);
                            premises.replaceWithStrongGround(obstacle.positionX, obstacle.positionY);
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
            Console.WriteLine("Bot Pos : {0}", rescueBot.returnXpos());
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveForward();
            Console.WriteLine("Bot Pos : {0}", rescueBot.returnXpos());
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveForward();
            Console.WriteLine("Bot Pos : {0}", rescueBot.returnXpos());
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveForward();
            Console.WriteLine("Bot Pos : {0}", rescueBot.returnXpos());
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveForward();
            Console.WriteLine("Bot Pos : {0}", rescueBot.returnXpos());
            rescueBot.updateSurroundings();
            Console.WriteLine("PosY{0}, PosX{1}",rescueBot.positionY,rescueBot.positionX);
            rescueBot.driveForward();
            */

            // TODO:
            // Navigations algorithmus
            // Automatisches aufsammeln von passenden gegenständen
            // wenn sie sich links, rechts, vor oder hinter dem fahrzeug befinden
            // entfernen der gegenstände auf der Karte                              DONE
            // Bot auf der Karte anzeigen
            // Bot auf der Karte bewegen
            
            rescueBot.startNavigation(rescueBot);

        }
    }
}
