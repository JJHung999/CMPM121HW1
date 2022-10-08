using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3Script : MonoBehaviour
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
    private float movementSpeed = 200f;

    // Update is called once per frame
    void Update()
    {
        //Set input to 0
        float horizontalInput = 0;
        //Input.GetAxis("Horizontal")
        //Set input to time as a way for automatically moving forward
        float verticalInput = Time.deltaTime * 10;
        //Input.GetAxis("Vertical")

        //If object travels a certain distance, teleport back to original position
        if (transform.position.z >= 222)
        {
            transform.position = new Vector3 (470,-191,47);
        }

        //update the position
        transform.position = transform.position + new Vector3(0, 0, 
                            verticalInput * movementSpeed * Time.deltaTime);

        //output to log the position change
        //Debug.Log(transform.position.z);
    }
}