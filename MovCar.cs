using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCar : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update

    public float forwardForce = 1500f;
    public float sidewaysForce = 500f;

    void Start()
    {
       
    }

    // Update is called once per frame
    //Uso el método FixedUpdated() para las físicas
    void FixedUpdate()
    {
        //Añadir una fuerza para avanzar
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        
    }
}
