using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayGun : MonoBehaviour
{
    public Transform shootPoint;
    public int damage;
    public int force;
    public float rango;

    private RaycastHit hit;
    public int maxBalas;
    public int balasActuales;

    void Start()
    {
        balasActuales = maxBalas;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.instance.balasActuales > 0)
        {
            AudioManager.instance.PlaySound("Disparo");
            GameManager.instance.balasActuales--;
            if (Physics.Raycast(shootPoint.position, shootPoint.forward, out hit, rango))
            {
                Debug.Log("Golpeaste a: " + hit.transform.name);
                VidaEnemigos vidaEnemigos = hit.transform.GetComponent<VidaEnemigos>();
                if (vidaEnemigos != null)
                {
                    vidaEnemigos.Danio(damage);
                    if (vidaEnemigos.vida <= 0)
                    {
                        Destroy(hit.transform.gameObject);
                    }
                }
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * force);
            }

            //if (GameManager.instance.HayBalas())
            //{
            //    GameManager.instance.RestarBala();
            //}
            Debug.Log("Balas restantes: " + balasActuales);
        }
        else if (Input.GetMouseButtonDown(0) && GameManager.instance.balasActuales <= 0)
        {
            Debug.Log("No tienes balas");
        }

        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    AudioManager.instance.PlaySound("Recarga");
        //    int balasFaltantes = maxBalas - balasActuales;
        //    if (balasFaltantes > 0)
        //    {
        //        if (balasFaltantes >= maxBalas)
        //        {
        //            balasActuales = maxBalas;
        //        }
        //        else
        //        {
        //            GameManager.instance.RecargarBalas();
        //        }
        //        Debug.Log("Cargando balas. Balas restantes: " + balasActuales);
        //    }
        //}
    }
}
