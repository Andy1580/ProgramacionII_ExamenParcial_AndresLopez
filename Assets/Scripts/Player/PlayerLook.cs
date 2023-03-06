using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    private Transform player;
    private float mouseX;
    private float mouseY;
    private float xRotate = 0;

    [Header ("Velocidad de camara")]
    [SerializeField] private float mouseXSense;
    [SerializeField] private float mouseYSense;

    void Start()
    {       
        player = transform.parent;

        Cursor.lockState = CursorLockMode.Locked;
    }
 
    void Update()
    {
        Look();
    }

    void Look()
    {
        xRotate -= mouseY;

        xRotate = Mathf.Clamp(xRotate, -90, 90);

        mouseX = Input.GetAxis("Mouse X") * mouseXSense * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseYSense * Time.deltaTime;

        player.Rotate(Vector3.up * mouseX);

        transform.localRotation = Quaternion.Euler(xRotate, 0, 0);

    }
}
