using System;

namespace Implementierung
{
    public class Motor
    {
        int maxDrehzahl;
        string motorName;
        bool motorState;        // True = on   False = off
        
        public void empfangeSignal()
        {

        }
        public void motorOff()
        {

        }
        public void motorOn()
        {

        }
    }

    class RescueBot
    {
        int eigenePositionX;
        int eigenePositionY;

        public void erknneStandort()
        {
            
        }
        public void signalAbfrage()
        {
            
        }
        public void empfangeSignal()
        {
            
        }
        public void verfolgeSignal()
        {
            
        }
        public void fahreVorwearts()
        {
            
        }
        public void fahreRueckwaerts()
        {
            
        }
        public void fahreLinks()
        {
            
        }
        public void fahreRechts()
        {
            
        }
        public void schwimmeVorwaerts()
        {
            
        }
        public void schwimmeRueckwaerts()
        {
            
        }
        public void schwimmeLinks()
        {
            
        }
        
        public void schwimmeRechts()
        {
            
        }
        
        public void stoppen()
        {
            
        }
        
        public void messenObjekt()
        {
            
        }
        
        public void greifen()
        {
            
        }
        
        public void ablegenObjekt()
        {
            
        }     

        static void Main(string[] args)
        {
            Console.WriteLine("Lass wen retten");

            // Greifen subsystem:
            Greifarm greifarm = new Greifarm();
            Greifer greifer = new Greifer();
            ZugkraftAufnehmer zugSensor = new ZugkraftAufnehmer();
            Stützklappe stütze = new Stützklappe();
            BoxDeckel boxDeckel = new BoxDeckel();

            // Kommunikation-Subsystem:
            Kamera kamera = new Kamera();
            Mikrofon mikrofon = new Mikrofon();
            Lautsprecher lautsprecher = new Lautsprecher();

            // Navigation-Subsystem:
            Navigation navigation = new Navigation();

            // Signalverfolgung-Subsystem:
            Signalverfolgung signalverfolgung = new Signalverfolgung();

            // Objektbergung-Subsystem:
            Objektbergung objektbergung = new Objektbergung();
            LIDARSensor LIDARSensor = new LIDARSensor();
            Geigerzaehler geigerzaehler = new Geigerzaehler();

            // test
            greifer.schliessen();
        }
    }
}
