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

    public bool detectObstacle(object[,] map, int posX, int posY)
    // Guckt ob an den angegebenen koordinaten ein Hinderniss liegt.
    {
        if (map[posY, posX].GetType() == typeof(Obstacle))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public Ground[] detectSourroundings(int botPosX, int botPosY, Premises premises)
    {
        // 0 = current, 1 = left, 2 = right, 3 = behind, 4 = infront
        // Cast the objects to Ground Objects
        Ground[] sourroundings = new Ground[5];
        
        sourroundings[0] = (Ground)premises.returnUnderground(botPosX, botPosY);
        sourroundings[1] = (Ground)premises.returnUnderground(botPosX - 1, botPosY);
        sourroundings[2] = (Ground)premises.returnUnderground(botPosX + 1, botPosY);
        sourroundings[3] = (Ground)premises.returnUnderground(botPosX, botPosY + 1);
        sourroundings[4] = (Ground)premises.returnUnderground(botPosX, botPosY - 1);
        
        return sourroundings;
    }
    public int sendSignal()
    {
        
        int signal = 1337;
        return signal;
    }
    public double determineSize(Obstacle obstacle)
    {
        double size = obstacle.returnSize();
        return size;
    }
}

public class GeigerCounter
{
    public GeigerCounter()
    {
        Console.WriteLine("Geiger Counter started!");
    }

    int sensorID;
    public double measureRadioactivity(RadioactiveObstacle obstacle)
    {
        return obstacle.returnRadiation();
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
    
	public double measureWeight(RadioactiveObstacle obstacle)
	{
		double weight = obstacle.returnWeight();
		return weight;
	}
}

public class CapacitySensor
{
    public CapacitySensor()
    {
        Console.WriteLine("Capacity Sensor started!");
    }
    public bool checkWater(int botPosX, int botPosY, Premises premises)
    {
        if (premises.returnUnderground(botPosX,botPosY).GetType() == typeof(Water))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
}