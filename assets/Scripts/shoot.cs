using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Rigidbody jugend;
    public Rigidbody rentner;
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int hiphop_munition = 10;
    public void hiphop_shooting()
    {
        if (hiphop_munition > 0)
        {
            Rigidbody instantiatedProjectile = Instantiate(rentner, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            hiphop_munition--;
            Debug.Log(hiphop_munition);
        }
    }


    public int klassik_munition = 10;
    public void klassik_shooting()
    {
        if (klassik_munition > 0)
        {
            Rigidbody instantiatedProjectile = Instantiate(jugend, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            klassik_munition--;
            Debug.Log(klassik_munition);
        }
    }

    public int hardstyle_munition = 10;
    public void hardstyle_shooting()
    {
        if (hardstyle_munition > 0)
        {
            Rigidbody instantiatedProjectile = Instantiate(rentner, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            hardstyle_munition--;
            Debug.Log(hardstyle_munition);
        }
    }

    public int tiktok_munition = 10;
    public void tiktok_shooting()
    {
        if (tiktok_munition > 0)
        {
            Rigidbody instantiatedProjectile = Instantiate(rentner, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            tiktok_munition--;
            Debug.Log(tiktok_munition);
        }
    }
}
