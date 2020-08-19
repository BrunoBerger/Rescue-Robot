using System;

namespace Implementierung
{
    public class Navigation
    {
        public Navigation()
        {
            Console.WriteLine("Navigation started!");
        }
        public void detectBarrier()
        {

        }
        public void detectWater()
        {

        }
        public void startNavigation(RescueBot rescuebot, int destX, int destY)
        {
            // navigation
            // zu erst muss geguckt werden in welche richtung gefahren werden soll.
            // dazu sollte ständig eine differnez zwischen x und y wert berechnet werden
            // ziel ist es die differenz auf 1 1 zu bringen
            // Sollte der bot vor einem Hinderniss stehen, muss er sich einen anderen Weg suchen
            // ---> objekt umfahren und weiter zu ziel

            int destinationX = destX;
            int destinationY = destY;

            int differenzX = destinationX - rescuebot.returnXpos();
            int differenzY = destinationY - rescuebot.returnYpos();
            Console.WriteLine("PosY{0}, PosX{1}",rescuebot.returnYpos(),rescuebot.returnXpos());
            rescuebot.updateSurroundings();
            rescuebot.driveForward();
        }
    }
}
