using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //movement speed in units per second
    private float movementSpeed = 180f;

    // Update is called once per frame
    void Update()
    {
        //Set the old position
        float ogposition = new Vector3 (0.0f,0.0f,0.0f);
        //get the Input from Horizontal axis (arrow keys)
        float horizontalInput = 0;
        //Input.GetAxis("Horizontal")
        //get the Input from Vertical axis
        float verticalInput = Time.deltaTime;
        //Input.GetAxis("Vertical")

        //If object travels a certain distance, teleport back to original position
        if transform.position(horizontalInput * movementSpeed * Time.deltaTime, 0, 222)
        {
            transform.position = ogposition;
        }

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput
                            * movementSpeed * Time.deltaTime, 0, 
                            verticalInput * movementSpeed * Time.deltaTime);

        //output to log the position change
        Debug.Log(transform.position);
    }

    //Teleport the object back to it's original position
    void teleport()
    {

    }
}
