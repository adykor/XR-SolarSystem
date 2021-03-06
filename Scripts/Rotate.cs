using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float degreesPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("The start method was run!");
    } 

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime);
        //Rotate the object by a certain speed on the Y axis  
        transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);
    }
}
