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

22 x 20 

H = Hinderniss                  Heißt hier piece of rock und ist ein nicht bewegliches Hinderniss
B = Objekt was zum bergen       Heißt hier obstacle und kann aus dem weg geräumt werden wenn es leicht genug ist.
W = Wasser                      
0 = Freiefahrt
X = Äußere begrenzung
S = Startpunkt
F = Funkturm
R = Radioaktives Dingen

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
                    case "X":
                            objArr[i,j] = new Wall();
                        break;
                    
                    case "H":
                            objArr[i,j] = new PieceOfRock(j,i);
                        break;

                    case "B":
                            // NextDouble = wert zwischen 0.0 und 1.0
                            // randSize = Wert zwischen 2 und 12
                            // randWeight = wert zwischen 3 und 23
                            double randSize = random.NextDouble() * 10 + 2;
                            double randWeight = random.NextDouble() * 20 + 3;
                            objArr[i,j] = new Obstacle(randWeight,randSize,j,i);
                        break;

                    case "W":
                        break;
                    
                    case "S":
                        break;
                    
                    case "F":
                        break;

                    case "0":
                        break;

                    case "R":
                        break;
                    default:
                            Console.WriteLine("Letter {0} not Found!", mapArr[i,j]);
                        break;
                }                
            }

            Console.WriteLine();
        }
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

        Console.WriteLine("Obstacle generated: X: {0} , Y: {1} , Weight: {2} , Size: {3}", positionX,positionY, weightKG, size);
    }
    int positionX;
    int positionY;
	double weightKG;
	double size;
}


public class RadioactiveObstacle : Obstacle
{
    int weightKG;
    int size;
    int positionX;
    int positionY;
    int radioactiveValue;
    public RadioactiveObstacle(int Weight, int Size, int PositionX, int PositionY, int Radiation) : base(Weight, Size, PositionX,PositionY)
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
    public StrongGround()
    {
        Console.WriteLine("Strong Ground Generated!");
    }
}
public class RadioTower
{
    int coordinateX;
    int coordinateY;
    string ID;
    public RadioTower()
    {
        Console.WriteLine("Radio Tower Generated!");
    }
    // TODO: Model um ne variable für die Koordinaten erweitern

}
public class RadioSignal
{
    // TODO: Model um ne variable für die ID erweitern
    int ID;
}

public class Person
{
    int positionX;
    int positionY;
    string kindOfHurt;

    public Person(int positionX, int positionY, string kindOfHurt)
    {
        Console.WriteLine("Person Generated!");
    }
    // ToDo: Position über float / int? einheitlich für alle umsetzen

}

}

