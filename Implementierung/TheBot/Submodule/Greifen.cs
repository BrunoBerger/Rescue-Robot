using System;

namespace Implementierung
{

public class Greifarm
{
	int position;
	int zielposition;

	public void drehen()
	{

	}
	public void zielposition_anfahren()
	{

	}
}
public class Greifer
{
	// TODO: Model um ne variable für den greifer ergänzen
    public void schliessen()
    {
        Console.WriteLine("Mache Zange zu");
    }
}
public class ZugkraftAufnehmer
{
	public int wirkendeKraft_messen()
	{
		int kraft = 100;
		return kraft;
	}
}



public class Stützklappe
{
	public void ausfahren()
	{

	}
	public void einfahren()
	{
		
	}
}
public class BoxDeckel
{
	public void oeffnen()
	{

	}
	public void schliessen()
	{
		
	}
}

}

// TODO2:
// "Wirklich alles int?"