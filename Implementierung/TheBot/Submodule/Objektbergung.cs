using System;

namespace Implementierung
{

public class LIDARSensor
{
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
	public double measure_acting_force()
	{
		double force = 100.1;
		return force;
	}
}

}