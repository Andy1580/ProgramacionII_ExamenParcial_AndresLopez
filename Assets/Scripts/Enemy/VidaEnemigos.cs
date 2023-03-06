using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigos : MonoBehaviour
{
    [Header ("Vida del enemigo")]
    [SerializeField] public int vida;

    public void Danio(int danio)
    {
        vida -= danio;
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
