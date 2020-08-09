using System;

namespace Implementierung
{

public class LIDARSensor
{

    public LIDARSensor()
    {
        Console.WriteLine("LIDAR Sensor started!");
    }

    int sensorID;
    public void detectObstacle()
    {

    }
    public int sendSignal()
    {
        int signal = 1337;
        return signal;
    }
}

public class GeigerCounter
{
    public GeigerCounter()
    {
        Console.WriteLine("Geiger Counter started!");
    }

    int sensorID;
    public int measureRadioactivity()
    {
        int radioaktivitaet = 420;
        return radioaktivitaet;
    }
    public int sendValue()
    {
        int wert = 9;
        return wert;
    }
}

public class ForceTransducer
{
    public ForceTransducer()
    {
        Console.WriteLine("Force Transducer started!");
    }
    
	public double measure_acting_force()
	{
		double force = 100.1;
		return force;
	}
}

}