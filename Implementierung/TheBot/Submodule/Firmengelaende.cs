using System;

namespace Implementierung
{
public class Firmengelände
{
    int laenge;
    int breite;
   
    string[,] MapArr = new string[22, 20] {
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

public class Objekt
{
	int gewichtKG;
	int groesze;
	public Objekt(int m)
	{
		gewichtKG = m;
	}
}

public class RadioaktivesObjekt : Object
{
    int strahlungswert;
}
public class Wasserloch
{

}

public class Wand
{

}
public class NebelRauch
{

}
public class Gesteinsbrocken
{

}
public class FesterUntergrund
{

}
public class Antennenmast
{
    // TODO: Model um ne variable für die Koordinaten erweitern
    int koordinateX;
    int koordinateY;
    string ID;
}
public class Radiosignal
{
    // TODO: Model um ne variable für die ID erweitern
    int ID;
}

public class Person
{
    // ToDo: Position über float / int? einheitlich für alle umsetzen
    int positionX;
    int positionY;
    string Verletzungsart;
}

}

