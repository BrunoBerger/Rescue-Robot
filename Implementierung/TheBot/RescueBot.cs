using System;

namespace Implementierung
{
    class RescueBot
    {
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
