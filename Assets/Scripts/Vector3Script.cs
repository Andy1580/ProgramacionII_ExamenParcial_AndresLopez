using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Vector3Script : MonoBehaviour
{
    Vector3 positionVect = new Vector3 (2,3,4);
    public float magn;


    private void Update()
    {
        //transform.Translate - translada el objeto en la direccion y magnitud que le pones por frame


        //transform.Translate(Vector3.right * 5 * Time.deltaTime + Vector3.back * 2 * Time.deltaTime);

        // transladarse (1,0,0)    * 5    5,0,0                +       transladarse (0,0, -1) * 0,0,-2
        //(5,0,-2)

        //transform.Translate(Vector3.one * -3 * Time.deltaTime);
        //(1,1,1);

        transform.Translate(positionVect.normalized * Time.deltaTime);


        if(positionVect.magnitude>0)
        {
            Debug.Log("Se mueve");
        }
    }
}
