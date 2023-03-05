using TMPro;
using UnityEngine;

public class BalasUI : MonoBehaviour
{
    private TextMeshProUGUI pro;

    private void Start()
    {

        pro = GetComponent<TextMeshProUGUI>();

    }

    private void Update()
    {

        pro.text = "x" + GameManager.instance.balasActuales.ToString();

    }
}

