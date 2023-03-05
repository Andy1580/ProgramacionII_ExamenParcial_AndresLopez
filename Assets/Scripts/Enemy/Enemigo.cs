using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{

    private NavMeshAgent agent;

    public Transform player;

    public string cambioDeEscena;


    
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        AudioManager.instance.PlaySound("Alien");

    }

    void Update()
    {

        agent.SetDestination(player.position);
        AudioManager.instance.PlaySound("Alien");

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            
            SceneManager.LoadScene(cambioDeEscena);
            GameManager.instance.balasActuales = GameManager.instance.maxBalas;
            Debug.Log("Se reinicio la escena");
        }


    }
}


