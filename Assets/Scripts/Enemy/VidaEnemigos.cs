using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigos : MonoBehaviour
{
    public int vida;

    public void Danio(int danio)
    {
        vida -= danio;
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
