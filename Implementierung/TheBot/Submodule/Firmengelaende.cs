using System;

namespace Implementierung
{
public class Premises
{
    
    int length;
    int width;
    string[,] mapArr = new string[22, 20] {
        {"X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X"},
        {"X", "F", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "F", "X"},
        {"X", "0", "0", "0", "R", "0", "0", "0", "0", "R", "0", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "B", "0", "0", "0", "0", "B", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "R", "0", "0", "0", "0", "R", "0", "R", "R", "0", "0", "0", "R", "H", "H", "H", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "H", "H", "H", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "0", "0", "H", "0", "0", "0", "0", "0", "0", "H", "H", "H", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "0", "0", "H", "H", "H", "0", "0", "0", "0", "H", "H", "H", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "B", "0", "H", "H", "H", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "H", "H", "H", "0", "0", "0", "H", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "H", "H", "H", "0", "0", "0", "H", "0", "0", "R", "0", "X"},
        {"X", "0", "B", "0", "0", "0", "0", "0", "H", "W", "W", "0", "0", "0", "H", "H", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "W", "W", "W", "0", "0", "0", "H", "H", "0", "0", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "0", "0", "W", "W", "W", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "0", "0", "W", "W", "W", "0", "0", "0", "0", "0", "0", "0", "R", "X"},
        {"X", "0", "0", "H", "H", "0", "W", "W", "W", "W", "W", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "R", "0", "0", "0", "W", "W", "W", "W", "W", "0", "H", "H", "H", "0", "R", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "W", "W", "W", "W", "W", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "W", "W", "W", "W", "W", "0", "P", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "H", "H", "0", "0", "0", "R", "0", "B", "0", "0", "0", "0", "X"},
        {"X", "S", "0", "0", "0", "0", "0", "H", "H", "0", "0", "0", "0", "0", "0", "0", "R", "0", "F", "X"},
        {"X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X"}
    };
    object[,] objArr = new object[22, 20];
    public Premises(int Length, int Width)
    {
        this.length = Length;
        this.width = Width;
        Console.WriteLine("Premises started!");
    }
    
/*
------------------------------------------------------------------------------------------------------------------------------------------------
H = Hinderniss                  Heißt hier piece of rock und ist ein nicht bewegliches Hinderniss
B = Objekt was zum bergen       Heißt hier obstacle und kann aus dem weg geräumt werden wenn es leicht genug ist.
W = Wasser                      
0 = Freiefahrt
X = Äußere begrenzung
S = Startpunkt
F = Funkturm
R = Radioaktives Dingen
P = Person
------------------------------------------------------------------------------------------------------------------------------------------------
!!!Der 0-Punkt ist die Obere Linke Ecke!!!
0 1 2 3 
1
2
3
------------------------------------------------------------------------------------------------------------------------------------------------
*/
    public void generateMap()
    {
        Random random = new Random();
        for (int i = 0; i < mapArr.GetLength(0); i++)
            {
                for (int j = 0; j < mapArr.GetLength(1); j++)
                {
                    switch (mapArr[i,j])
                    {
                        // Wand
                        case "X":
                                this.objArr[i,j] = new Wall();
                            break;
                        // Unüberwindbares Hinderniss
                        case "H":
                                this.objArr[i,j] = new PieceOfRock(j,i);
                            break;
                        // Objekt was aus dem weg geräumt werden kan, wenn es gewissen Anforderungen entspricht
                        case "B":
                                // NextDouble = wert zwischen 0.0 und 1.0
                                // randSize = Wert zwischen 2 und 12
                                // randWeight = Wert zwischen 3 und 23
                                // Runden auf 4 Nachkommastellen

                                double randSize = Math.Round(random.NextDouble() * 10 + 2, 4, MidpointRounding.ToEven);
                                double randWeight = Math.Round(random.NextDouble() * 20 + 3, 4, MidpointRounding.ToEven);
                                this.objArr[i,j] = new Obstacle(randWeight,randSize,j,i);
                            break;
                        // Wasser
                        case "W":
                                this.objArr[i,j] = new Water();
                            break;
                        // Starpunkt und Rescue Bot initialisierung
                        case "S":
                                this.objArr[i,j] = new StartingPoint(j,i);
                                RescueBot rescueBot = new RescueBot(j,i);
                            break;
                        // Funkturm
                        case "F":
                                this.objArr[i,j] = new RadioTower(j,i);
                            break;
                        // Normaler Boden -> Freie fahrt!
                        case "0":
                                this.objArr[i,j] = new StrongGround(j,i);
                            break;
                        // Radioaktives Objekt. Kann unter bestimmten vorraussetzungen geborgen werden
                        case "R":
                                // NextDouble = wert zwischen 0.0 und 1.0
                                // randSizeRad = Wert zwischen 2 und 12
                                // randWeightRad = Wert zwischen 3 und 23
                                // randRad = Wert zwischen 0 und 50
                                // Runden auf 4 Nachkommastellen

                                double randSizeRad = Math.Round(random.NextDouble() * 10 + 2, 4, MidpointRounding.ToEven);
                                double randWeightRad = Math.Round(random.NextDouble() * 20 + 3, 4, MidpointRounding.ToEven);
                                double randRad = Math.Round(random.NextDouble() * 50 , 4, MidpointRounding.ToEven);
                                this.objArr[i,j] = new RadioactiveObstacle(randWeightRad,randSizeRad,j,i,randRad);
                            break;
                        // Person 
                        case "P":
                                // Villeicht n Array mit verschiedenen schädigungen der Person aus dem eine Zufällige ausgewält wird
                                this.objArr[i,j] = new Person(j,i,"Broken Arm");
                            break;
                        // default
                        default:
                                Console.WriteLine("Letter {0} not Found!", mapArr[i,j]);
                            break;
                    }                
                }
            }
    }

    public object returnUnderground(int x,int y)
    {
        object a = objArr[y,x];
        return a;
    }

}


public class Obstacle
{
    public Obstacle(double Weight, double Size, int PositionX, int PositionY)
    {
        this.positionX = PositionX;
        this.positionY = PositionY;
        this.weightKG = Weight;
        this.size = Size;

        Console.WriteLine("Obstacle generated: X: {0} , Y: {1} , Weight: {2} , Size: {3}", this.positionX,this.positionY, this.weightKG, this.size);
    }
    int positionX;
    int positionY;
	double weightKG;
	double size;
}


public class RadioactiveObstacle : Obstacle
{
    double weightKG;
    double size;
    int positionX;
    int positionY;
    double radioactiveValue;
    public RadioactiveObstacle(double Weight, double Size, int PositionX, int PositionY, double Radiation) : base(Weight, Size, PositionX,PositionY)
    {
        this.weightKG = Weight;
        this.size = Size;
        this.positionX = PositionX;
        this.positionY = PositionY;
        this.radioactiveValue = Radiation;   
        Console.WriteLine("Radioactive Obstacle generated! X: {0} , Y: {1} , KG: {2} , Size: {3} ,Rad: {4}", this.positionX,this.positionY,this.weightKG,this.size,this.radioactiveValue);
    }
}

public class Water
{
    public Water()
    {

    }
}

public class StartingPoint
{
    int positionX;
    int positionY;
    public StartingPoint(int posX, int posY)
    {
        this.positionX = posX;
        this.positionY = posY;
        Console.WriteLine("Starting Point at X:{0}, Y:{1}",this.positionX,this.positionY);
    }
}

public class Wall
{
    // im Diagramm hinzufügen
    int positionX;
    int positionY;
    public Wall()
    {
        Console.WriteLine("Wall Generated!");
    }

}
public class Fog
{
    // im Diagramm hinzufügen
    int positionX;
    int positionY;
    public Fog()
    {
        Console.WriteLine("Fog Generated!");
    }
}
public class PieceOfRock
// Nicht bewegbares Hinderniss!
{
    // im Diagramm hinzufügen
    int positionX;
    int positionY;
    public PieceOfRock(int posX, int posY)
    {
        this.positionX = posX;
        this.positionY = posY;
        Console.WriteLine("Piece of Rock Generated at X:{0} and Y:{1}!", posX, posY);
    }
}
public class StrongGround
{
    // im Diagramm hinzufügen
    int positionX;
    int positionY;
    public StrongGround(int posX, int posY)
    {
        this.positionX = posX;
        this.positionY = posY;
        Console.WriteLine("Strong Ground Generated at X:{0} and Y:{1}!",this.positionX,this.positionX);
    }
}
public class RadioTower
{
    int coordinateX;
    int coordinateY;
    string ID;
    public RadioTower(int coordX, int coordY)
    {
        this.coordinateX = coordX;
        this.coordinateY = coordY;
        Console.WriteLine("Radio Tower Generated at X:{0} and Y:{1}!",this.coordinateX,this.coordinateY);
    }
    // TODO: Model um ne variable für die Koordinaten erweitern
}
public class RadioSignal
{
    // TODO: Model um ne variable für die ID erweitern
    int ID;
    public RadioSignal(int id)
    {
        this.ID = id;
    }
}

public class Person
{
    int positionX;
    int positionY;
    string kindOfHurt;

    public Person(int positionX, int positionY, string kindOfHurt)
    {
        Console.WriteLine("Person Generated at X:{0} and Y:{1}!");
    }

}

}

