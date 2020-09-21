using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()//bætti fixed afþví ég er að nota physics engine
    {
        //þetta ýtir playerinn áfram
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        //beygja til hægri
        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0);
        }
        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0);
        }
    }
}
