
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rentner : MonoBehaviour
{
    public float speed = 1;
    public GameObject targ;

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "rentner_bullet")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            speed = -2;
        }
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, speed * Time.deltaTime);



    }




}
