using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header ("ControlDeBalas")]
    [SerializeField] public int balasActuales = 6;
    [SerializeField] public int maxBalas = 6;
    

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
}



