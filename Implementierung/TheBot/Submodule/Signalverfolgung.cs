using System;

namespace Implementierung
{
public class Antenna
{
    public void getSignal()
    {

    }
}

public class LeftAntenna : Antenna
{
    public LeftAntenna()
    {
        Console.WriteLine("Left Antenna started!");
    }
}
public class RightAntenna : Antenna
{
    public RightAntenna()
    {
        Console.WriteLine("Right Antenna started!");
    }
}
public class BacksideAntenna : Antenna
{
    public BacksideAntenna()
    {
        Console.WriteLine("Backside Antenna started!");
    }
}
}