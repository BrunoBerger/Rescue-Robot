using System;

namespace Implementierung
{

public class Grappler
{
	public Grappler()
    {
		this.motorGrapplerRotation = new Motor(100,"GrapplerRotation",false,0,360);
		this.motorGrapplerTilt = new Motor(100,"GrapplerTilt",false,0,180);
		this.motorGrapplerJoint1 = new Motor(100,"GrapplerJoint1",false,-90,90);
		this.motorGrapplerJoint2 = new Motor(100,"GrapplerJoint2",false,-90,90);
        Console.WriteLine("Grappler started!");
    }
	int position;
	int target_position;
	Motor motorGrapplerRotation;
	Motor motorGrapplerTilt;
	Motor motorGrapplerJoint1;
	Motor motorGrapplerJoint2;


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
	Motor motorGripperRotation;
	Motor motorGripper;
	public Gripper()
    {
		this.motorGripperRotation = new Motor(100,"GripperRotation",false,0,360);
		this.motorGripper = new Motor(100,"GrapplerTilt",false,0,100);
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