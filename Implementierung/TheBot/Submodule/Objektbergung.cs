using System;

namespace Implementierung
{
public class Objektbergung
{
    public void erkenne_Objekt()
    {

    }
    public void messe_Radioaktivität()
    {

    }
        public void sendeWert()
    {

    }
}

public class LIDARSensor
{
    int sensorID;
    public void erkenneObjekt()
    {

    }
    public int sendeSignal()
    {
        int signal = 1337;
        return signal;
    }
}

public class Geigerzaehler
{
    int sensorID;
    public int misst_Radioaktivitaet()
    {
        int radioaktivitaet = 420;
        return radioaktivitaet;
    }
    public int sendetWert()
    {
        int wert = 9;
        return wert;
    }
}

public class ZugDruckaufnehmer
{
    public double ermittleGewicht()
    {
        double wert = 1.1;
        return wert;
    }
}
}