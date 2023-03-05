using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float movX;
    private float movZ;

    [SerializeField] 
    private float speed;
    public float jumpSpeed;

    private CharacterController controler;

    private Vector3 velocity;

    public float gravity = -9.81f;

    public bool isGrounded;
    public Transform groundCheck;
    public float radius;
    public LayerMask whatIsGround;

    private void Start()
    {
        controler = GetComponent<CharacterController>();
        AudioManager.instance.PlaySound("Music");
    }

    void Update()
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
