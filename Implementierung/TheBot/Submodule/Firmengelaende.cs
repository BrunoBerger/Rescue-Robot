using System;

namespace Implementierung
{
public class Premises
{
    public Premises()
    {
        Console.WriteLine("Premises started!");
    }
    int length;
    int width;
   
    string[,] mapArr = new string[22, 20] {
        {"X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X"},
        {"X", "F", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "F", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "B", "0", "0", "0", "0", "B", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "H", "H", "H", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "H", "H", "H", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "0", "0", "H", "0", "0", "0", "0", "0", "0", "H", "H", "H", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "0", "0", "H", "H", "H", "0", "0", "0", "0", "H", "H", "H", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "B", "0", "H", "H", "H", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "H", "H", "H", "0", "0", "0", "H", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "H", "H", "H", "0", "0", "0", "H", "0", "0", "0", "0", "X"},
        {"X", "0", "B", "0", "0", "0", "0", "0", "H", "W", "W", "0", "0", "0", "H", "H", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "0", "W", "W", "W", "0", "0", "0", "H", "H", "0", "0", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "0", "0", "W", "W", "W", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "0", "0", "W", "W", "W", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "H", "H", "0", "W", "W", "W", "W", "W", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "W", "W", "W", "W", "W", "0", "H", "H", "H", "0", "0", "0", "B", "X"},
        {"X", "0", "0", "0", "0", "0", "W", "W", "W", "W", "W", "0", "0", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "W", "W", "W", "W", "W", "0", "P", "0", "0", "0", "0", "0", "0", "X"},
        {"X", "0", "0", "0", "0", "0", "0", "H", "H", "0", "0", "0", "0", "0", "B", "0", "0", "0", "0", "X"},
        {"X", "S", "0", "0", "0", "0", "0", "H", "H", "0", "0", "0", "0", "0", "0", "0", "0", "0", "F", "X"},
        {"X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X"}
    };
/*

22 x 20 

H = Hinderniss
B = Objekt was zum bergen
W = Wasser
0 = Freiefahrt
X = Äußere begrenzung
S = Startpunkt
F = Funkturm

*/

}


public class Obstacle
{
    public Obstacle()
    {
        Console.WriteLine("Obstacle generated!");
    }
	int weightKG;
	int size;
}


public class RadioactiveObstacle : Obstacle
{
    
    public RadioactiveObstacle()
    {
        Console.WriteLine("Radioactive Obstacle generated!");
    }
    int radioactiveValue;
}

public class Water
{

}

public class Wall
{
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
{
    // im Diagramm hinzufügen
    int positionX;
    int positionY;
    public PieceOfRock()
    {
        Console.WriteLine("Piece of Rock Generated!");
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

