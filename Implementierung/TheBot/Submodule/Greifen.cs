using System;

namespace Implementierung
{

public class Grappler
{
	public Grappler()
    {
        Console.WriteLine("Grappler started!");
    }
	int position;
	int target_position;

	public void extend_out()
	{

	}
	public void liftObstacle()
	{

	}
	public void move_towards_box_pos()
	{
		
	}
	public void rotate()
	{

	}
	public void move_to_target_position()
	{

	}
}
public class Gripper
{
	public Gripper()
    {
        Console.WriteLine("Gripper started!");
    }
	// TODO: Model um ne variable für den greifer ergänzen
    public void closeGripper()
    {
        Console.WriteLine("Closes Gripper!");
    }
	public void openGripper()
	{
		Console.WriteLine("Opens Gripper!");
	}

}



public class Support
//Stützklappe!
{
	public Support()
    {
        Console.WriteLine("Support started!");
    }
	public void extend()
	// Im Diagramm ändern! Dort als "ascend" angegeben
	{
		Console.WriteLine("Support is extendet!");
	}
	public void retract()
	{
		Console.WriteLine("Support is retracted!");
	}
}
public class BoxCover
{
	public BoxCover()
    {
        Console.WriteLine("Box Cover started!");
    }
	public void openCover()
	{
		Console.WriteLine("Box cover is open!");
	}
	public void closeCover()
	{
		Console.WriteLine("Box cover is closed!");
	}
}

}

// TODO2:
// "Wirklich alles int?"