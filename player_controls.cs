using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_controls : MonoBehaviour
{
    public float jumpForce;

    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public float speed;

    private int doubleJump;
    public int doubleJumpValue;
    private float moveInput;
    public float MovementSpeed;
    AudioSource jumpsound;
    AudioSource deathsound;
    // Start is called before the first frame update
    void Start()
    {
        doubleJump = doubleJumpValue;
        rb = GetComponent<Rigidbody2D>();
        jumpsound = GetComponent<AudioSource>();
        deathsound = GetComponent<AudioSource>();


    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal"); // Move left and right A/D Key
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y); //Player movement

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); //Ground check on player to know he is standing on a solid surface
    }

    // Update is called once per frame
    void Update()
    {

        if (isGrounded == true)
        {
            doubleJump = doubleJumpValue;
        }
        if (Input.GetKeyDown(KeyCode.Space) && doubleJump > 0)
        {
            jumpsound.Play();
            rb.velocity = Vector2.up * jumpForce;
            doubleJump--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && doubleJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            deathsound.Play();
        }
    }
}
   
   
   



   
