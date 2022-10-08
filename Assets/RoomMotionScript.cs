using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMotionScript : MonoBehaviour
{
    Vector3 ogposition;

    // Start is called before the first frame update
    void Start()
    {
        //Set the old position
        ogposition = new Vector3 (0.0f,0.0f,0.0f);

        //Setting up random number generator
        // float rnd = new random();
        // float rndnum = rnd.Next(450 , 500);
    }

    //movement speed in units per second
    private float movementSpeed = 45f;

    // Update is called once per frame
    void Update()
    {
        //Set input to 0
        float horizontalInput = Time.deltaTime;
        //Input.GetAxis("Horizontal")
        //Set input to time as a way for automatically moving forward
        float verticalInput = 0;
        //Input.GetAxis("Vertical")

        //If object travels a certain distance, teleport back to original position
        if (transform.position.x <= 549)
        {
            transform.position = new Vector3 (566,-190,151);
        }

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime * -1, 0, 
                            0);

        //output to log the position change
        //Debug.Log(transform.position.x);
    }
}
