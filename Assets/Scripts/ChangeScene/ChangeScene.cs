using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private void Start()
    {
        AudioManager.instance.PlaySound("Nivel1");
    }  

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            AudioManager.instance.StopSound("Nivel1");
            AudioManager.instance.PlaySound("Nivel2");
            SceneManager.LoadScene("Cosa");
        }
    }
}
