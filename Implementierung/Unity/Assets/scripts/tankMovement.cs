﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMovement : MonoBehaviour
{
    public Rigidbody mainBody;
    public Rigidbody leftTrack;
    public Rigidbody rightTrack;
    public Rigidbody prop;
    public ParticleSystem splash;

    public Vector3 userInput;
    public Vector3 leftOutput;
    public Vector3 rightOutput;

    public Vector3 propOutput;
    public float turnInputWater;

    public float trackPower;
    public float propPower;
    public bool isGrounded;
    public bool senseWater;

    private float potGain;
    public float maxSpeed;
    public Vector3 currentHeading;
    public Vector3 desiredHeading;


    // Start is called before the first frame update
    void Start()
    {
      mainBody = this.GetComponent<Rigidbody>();
      leftTrack = this.transform.Find("leftTrack").GetComponent<Rigidbody>();
      rightTrack = this.transform.Find("rightTrack").GetComponent<Rigidbody>();
      prop = this.transform.Find("propeller").GetComponent<Rigidbody>();


      trackPower = 1500f;
      propPower = 2400;
      maxSpeed = 10f;

      Debug.Log("Bot_Rescue is ready to roll");
    }

    // Update is called once per frame
    void Update()
    {
      // drawDebugRays();
      userInput = new Vector3(Input.GetAxis("Horizontal"),0f,Input.GetAxis("Vertical"));
      potGain = mainBody.velocity.magnitude + leftOutput.magnitude + rightOutput.magnitude;
    }

    void FixedUpdate()
    {
      // driving on dry ground
      if (isGrounded == true && potGain < maxSpeed)
      {
        if(userInput.z != 0)
        {
          leftOutput = new Vector3(0f, 0f,userInput.z);
          rightOutput = new Vector3(0f, 0f, userInput.z);
        }
        else if (userInput.x != 0)
        {
          leftOutput = new Vector3(0f,0f,userInput.x);
          rightOutput = new Vector3(0f,0f,-userInput.x);
        }
        leftTrack.AddRelativeForce(leftOutput * trackPower);
        rightTrack.AddRelativeForce(rightOutput * trackPower);
      }

      // dringg in water
      if(senseWater == true)
      {
        prop.AddRelativeTorque(0, userInput.x * propPower, 0, ForceMode.Impulse);
        prop.AddRelativeForce(new Vector3(0f, 0f, userInput.z) * propPower);
        splash.Play();
      }
      else
      {
        splash.Pause();
        splash.Clear();
      }
    }


    // Collision-detection
    void OnCollisionEnter(Collision collisionInfo){
      if (collisionInfo.gameObject.tag == "boden"){
        isGrounded = true;
      }
      if (collisionInfo.gameObject.tag == "water"){
        senseWater = true;
      }
    }
    void OnCollisionExit(Collision collisionInfo){
      if (collisionInfo.gameObject.tag == "boden"){
        isGrounded = false;
      }
      if (collisionInfo.gameObject.tag == "water"){
        senseWater = false;
      }
    }

    void drawDebugRays(){
      currentHeading = this.transform.forward;
      Debug.DrawRay(leftTrack.transform.position, leftOutput * 8, Color.red);
      Debug.DrawRay(rightTrack.transform.position, rightOutput * 8, Color.blue);
      Debug.DrawRay(prop.transform.position, currentHeading * 8, Color.yellow);
      desiredHeading = userInput - this.transform.forward;
      Debug.DrawRay(mainBody.transform.position, desiredHeading * 15, Color.green);
    }
}
