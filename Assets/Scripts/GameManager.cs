using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    
    public int balasActuales = 6;
    public int maxBalas = 6;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    private void Start()
    {
        balasActuales = maxBalas;
        
        AudioManager.instance.PlaySound("Music");
        AudioManager.instance.PlaySound("Grillo");

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    // Aquí reiniciamos los valores necesarios
    //    balasActuales = maxBalas;
    //}

    //public void VidaPlayerDetection()
    //{
    //    if(CompareTag)
    //}

    //public void Update()
    //{
    //    //RecargarBalas();
    //}

    //public void RestarBala()
    //{
    //    balasActuales--;
    //    Debug.Log("Balas restantes: " + balasActuales);
    //}

    //public bool HayBalas()
    //{
    //    return balasActuales > 0;
    //}

    //public void RecargarBalas()
    //{
    //    int balasFaltantes = maxBalas - balasActuales;
    //    if (balasFaltantes > 0)
    //    {
    //        if (balasFaltantes >= maxBalas)
    //        {
    //            balasActuales = maxBalas;
    //        }
    //        else
    //        {
    //            balasActuales += balasFaltantes;
    //        }
    //        Debug.Log("Cargando balas. Balas restantes: " + balasActuales);
    //    }

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



