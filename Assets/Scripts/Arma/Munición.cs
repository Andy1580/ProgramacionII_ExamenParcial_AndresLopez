using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Munición : MonoBehaviour
{
    public float radio;
    public int valor;
    public bool check;
    public bool check2;

    public LayerMask whatIsPlayer;

    RaycastHit hit;

    private void OnMouseOver()
    {
        check = true;
    }

    private void OnMouseExit()
    {
        check = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && check && check2)
        {
            //GameManager.instance.balas += valor;
            Destroy(this.gameObject);
        }


        //Physics.SphereCast(transform.position, radio, Vector3.right,out hit);
        check2 = Physics.CheckSphere(transform.position, radio, whatIsPlayer);

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.instance.balasActuales += 5;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radio);
    }
}
