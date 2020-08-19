using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMovement : MonoBehaviour
{
    public Rigidbody mainBody;
    public Rigidbody leftTrack;
    public Rigidbody rightTrack;

    public Vector3 userInput;

    public float power = 1000f;
    public bool isGrounded;

    public Vector3 myVelocity;
    public Vector3 currentHeading;
    public Vector3 desiredHeading;


    // Start is called before the first frame update
    void Start()
    {
      mainBody = this.GetComponent<Rigidbody>();
      leftTrack = this.transform.Find("leftTrack").GetComponent<Rigidbody>();
      rightTrack = this.transform.Find("rightTrack").GetComponent<Rigidbody>();
      Debug.Log("Bot_Rescue is ready to roll");
    }

    // Update is called once per frame
    void Update()
    {
      userInput = new Vector3(Input.GetAxis("Horizontal")
                              ,0f,Input.GetAxis("Vertical"));
      currentHeading = this.transform.forward;
      drawDebugRays();
    }

    void FixedUpdate()
    {
      if (isGrounded == true)
      {
        mainBody.AddRelativeForce(userInput * power);
      }
    }

    void drawDebugRays()
    {
      Debug.DrawRay(transform.position, currentHeading * 8, Color.blue);
      Debug.DrawRay(transform.position, userInput * 15, Color.green);
    }

    // Collision-detection
    void OnCollisionEnter(Collision collisionInfo){
      if (collisionInfo.gameObject.name == "Terrain"){
        isGrounded = true;
      }
    }
    void OnCollisionExit(Collision collisionInfo){
      if (collisionInfo.gameObject.name == "Terrain"){
        isGrounded = false;
      }
    }
}
