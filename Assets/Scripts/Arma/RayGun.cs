using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayGun : MonoBehaviour
{
    [Header ("Atributos")]
    [SerializeField] public Transform shootPoint;
    [SerializeField] private int damage;
    [SerializeField] private int force;
    [SerializeField] private float rango;

    [Header ("Capacidad")]
    private RaycastHit hit;
    [SerializeField] public int maxBalas;
    [SerializeField] public int balasActuales;

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
        }
        else if (Input.GetMouseButtonDown(0) && GameManager.instance.balasActuales <= 0)
        {
            Debug.Log("No tienes balas");
        }
    }
}
