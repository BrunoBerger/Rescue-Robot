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
        public bool startNavigation(RescueBot rescuebot, int destX, int destY)
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
            
            
            while (differenzX != 0 || differenzY != 0)
            {
                // BACKWARD //////////////////////////////////////////////////////////////////////////////
                if(differenzY > 0)
                {
                    rescuebot.updateSurroundings();
                    if(rescuebot.driveBackward())
                    {
                        Console.WriteLine("PosY{0}, PosX{1}",rescuebot.returnYpos(),rescuebot.returnXpos());
                        differenzY = destinationY - rescuebot.returnYpos();
                    }else
                    {
                        do
                        {
                            rescuebot.driveRight();
                            rescuebot.updateSurroundings();
                            Console.WriteLine("PosY{0}, PosX{1}",rescuebot.returnYpos(),rescuebot.returnXpos());
                            differenzX = destinationX - rescuebot.returnXpos();
                        } while (rescuebot.driveBackward() == false);
                    }
                    if (differenzY == 1)
                    {
                        differenzY = 0;
                    }
                }
                // FORWARD //////////////////////////////////////////////////////////////////////////////
                if (differenzY < 0)
                {
                    rescuebot.updateSurroundings();
                    if(rescuebot.driveForward())
                    {
                        Console.WriteLine("PosY{0}, PosX{1}",rescuebot.returnYpos(),rescuebot.returnXpos());
                        differenzY = destinationY - rescuebot.returnYpos();
                    }
                    else{
                        do
                        {
                            rescuebot.driveLeft();
                            rescuebot.updateSurroundings();
                            Console.WriteLine("PosY{0}, PosX{1}",rescuebot.returnYpos(),rescuebot.returnXpos());
                            differenzX = destinationX - rescuebot.returnXpos();
                        } while (rescuebot.driveForward() == false);
                    }                    
                    if (differenzY == -1)
                    {
                        differenzY = 0;
                    }
                }
                // RIGHT //////////////////////////////////////////////////////////////////////////////
                if(differenzX > 0)
                {
                    rescuebot.updateSurroundings();
                    if(rescuebot.driveRight())
                    {
                        Console.WriteLine("PosY{0}, PosX{1}",rescuebot.returnYpos(),rescuebot.returnXpos());
                        differenzX = destinationX - rescuebot.returnXpos();
                    }else
                    {
                        do
                        {
                            rescuebot.driveForward();
                            rescuebot.updateSurroundings();
                            Console.WriteLine("PosY{0}, PosX{1}",rescuebot.returnYpos(),rescuebot.returnXpos());
                            differenzY = destinationY - rescuebot.returnYpos();
                        } while (rescuebot.driveRight() == false);
                    }
                    
                    if (differenzX == 1)
                    {
                        differenzX = 0;
                    }
                }
                // LEFT //////////////////////////////////////////////////////////////////////////////
                if (differenzX < 0)
                {
                    rescuebot.updateSurroundings();
                    if(rescuebot.driveLeft())
                    {
                        Console.WriteLine("PosY{0}, PosX{1}",rescuebot.returnYpos(),rescuebot.returnXpos());
                        differenzX = destinationX - rescuebot.returnXpos();
                    }else
                    {
                         do
                        {
                            rescuebot.driveBackward();
                            rescuebot.updateSurroundings();
                            Console.WriteLine("PosY{0}, PosX{1}",rescuebot.returnYpos(),rescuebot.returnXpos());
                            differenzY = destinationY - rescuebot.returnYpos();
                        } while (rescuebot.driveLeft() == false);
                    }
                    
                    if (differenzX == -1)
                    {
                        differenzX = 0;
                    }
                }

            }
            return true;        
        }
    }
}
