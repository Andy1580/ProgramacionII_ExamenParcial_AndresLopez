using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header ("ParametrosDeMovimiento")] 
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;
    private float movX;
    private float movZ;
    private CharacterController controler;
    private Vector3 velocity;

    [Header ("ParametrosDeGrounded")]
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private bool isGrounded;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float radius;
    [SerializeField] private LayerMask whatIsGround;
    
    private void Start()
    {
        controler = GetComponent<CharacterController>();
        AudioManager.instance.PlaySound("Music");
    }

    void Update()
    {
        Move();
    }

    void Move()
    { 
        isGrounded = Physics.CheckSphere(groundCheck.position, radius, whatIsGround);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = 0;
        }

        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        if(isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpSpeed * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        Vector3 move = transform.right * speed * movX + transform.forward * speed *movZ;
           
        controler.Move(move * Time.deltaTime);
        controler.Move(velocity * Time.deltaTime);

    }
}
