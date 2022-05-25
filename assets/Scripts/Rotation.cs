using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{

    public float keepRotateSpeed = 1f;

    int breite = Screen.width;
    int hoehe = Screen.height;




    void Update()
    {

        Vector3 mousePos = Input.mousePosition;
#if UNITY_EDITOR
        if (Input.GetButton("Fire1"))
        {
            if (mousePos.y < hoehe / 2 && mousePos.x > breite / 2)
            {
                RotateRightWard();

            }
            else if (mousePos.y > hoehe / 2 && mousePos.x > breite / 2)
            {

                RotateLeftWard();
            }
        }
#else
        if (Input.touchCount > 0)
        {
            if (mousePos.y < hoehe / 2 && mousePos.x > breite / 2)
            {
                RotateRightWard();

            }
            else if (mousePos.y > hoehe / 2 && mousePos.x > breite / 2)
            {

                RotateLeftWard();
            }
        }
#endif



    }
    public void RotateLeftWard()
    {
        transform.rotation = Quaternion.Euler(0f, 1 * keepRotateSpeed, 0f) * transform.rotation;
    }

    public void RotateRightWard()
    {
        transform.rotation = Quaternion.Euler(0f, -1 * keepRotateSpeed, 0f) * transform.rotation;
    }




}

