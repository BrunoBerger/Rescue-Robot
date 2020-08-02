using System;

namespace Implementierung
{
public class Firmengelände
{
    int laenge;
    int breite;
   
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
    float position;
    string Verletzungsart;
}

}