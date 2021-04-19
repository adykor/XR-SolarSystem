using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControl : MonoBehaviour
{
    public float turningForce;
    
    private Rigidbody rigidBody;

    private bool engineOn;

    public float engineForce;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Get our mouse controls
        float yaw = Input.GetAxis("Mouse X");
        float pitch = Input.GetAxis("Mouse Y");

        //Rotate the rocket using the mouse controls
        rigidBody.AddRelativeTorque(
            pitch * turningForce * Time.deltaTime, // Pitch
            yaw * turningForce * Time.deltaTime, // Yaw
            0f);                                 // Roll

        // Turn on the rocket engine when W is pressed
        if(Input.GetKeyDown(KeyCode.W))

        {
            engineOn = true;
        }


            // Turn off the rocket engine when W is released
            if (Input.GetKeyUp(KeyCode.W))

        {
            engineOn = false;
        }

            //Quite when you hit escape
            if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

            // If the engine is on
            if(engineOn)
        {
            //Apply an engine force
            rigidBody.AddRelativeForce(transform.forward * engineForce * Time.deltaTime);
        }
        
    }
}
