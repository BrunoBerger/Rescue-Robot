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
        this.gripper = new Gripper();
		this.forceTransducer = new ForceTransducer();
		Console.WriteLine("Grappler started!");

    }
	double maxLiftWeight = 20.0;
	int position;
	int target_position;
	Gripper gripper;
	ForceTransducer forceTransducer;
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
	public void move_to_target_position(int targetPosX, int targetPosY)
	{

	}
	public void closeGripper()
    {
		this.gripper.closeGripper();
        Console.WriteLine("Closes Gripper!");
    }
	public void openGripper()
	{
		this.gripper.openGripper();
		Console.WriteLine("Opens Gripper!");
	}
}

public class Gripper
{
	double maxSize = 10.0;
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
	bool state;	// False eingefahren || True ausgefahren
	public Support()
    {
		// state beim initialisieren auf false stellen
		this.state = false;
        Console.WriteLine("Support started!");
    }
	public void extend()
	// Im Diagramm ändern! Dort als "ascend" angegeben
	{
		this.state = true;
		Console.WriteLine("Support is extendet!");
	}
	public void retract()
	{
		this.state = false;
		Console.WriteLine("Support is retracted!");
	}
}
public class BoxCover
{
	bool state; // false = geschlossen| true = offen
	public BoxCover()
    {
		this.state = false;
        Console.WriteLine("Box Cover started!");
    }
	public void openCover()
	{
		this.state = true;
		Console.WriteLine("Box cover is open!");
	}
	public void closeCover()
	{
		this.state = false;
		Console.WriteLine("Box cover is closed!");
	}
}

}

// TODO2:
// "Wirklich alles int?"