using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpforce;
    public Transform ceilingCheck;
    public Transform groundCheck;
    public LayerMask groundObjects;
    public float checkRadius;
    public int maxJumpCount;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;
    private bool isJumping = false;
    public bool isGrounded;
    public int jumpCount;

    private void Start()
    {
        jumpCount = maxJumpCount;
    }
    // Awake is called after all objects are intialized, Called in a random oder
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // will look for a compent on this gameobject(what the script is attached to) of type Rigidbody.
    }

    // Update is called once per frame
    void Update()
    {
        // Get inputs
        ProcessInputs();

        //Animate
        Animate();

    }
    // Better for handling Physics, can be called multiply times per update frame.
    private void FixedUpdate()
    {

        // CHeck if grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObjects);
        if (isGrounded)
        {
            jumpCount = maxJumpCount;
        }
        // Move
        Move();

    }
    private void Move()
    {
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
            jumpCount--;
        }
        isJumping = false;
    }

    private void Animate()
    {
        if (moveDirection > 0 && !facingRight)

        {
            flipcharacter();
        }
        else if (moveDirection < 0 && facingRight)
        {
            flipcharacter();
        }
    }

    private void ProcessInputs()
    {
        moveDirection = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) & jumpCount > 0)
        {
            isJumping = true;
        }
    }

    private void flipcharacter()
    {
        facingRight = !facingRight; // Inverse bool

        transform.Rotate(0f, 180f, 0f);
    }

    IEnumerator PowerUpSpeed()
    {
        moveSpeed = 9;
        yield return new WaitForSeconds(5);
        moveSpeed = 5;
    }

    public void SpeedPowerUp()
    {
        StartCoroutine(PowerUpSpeed());
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "movingPlatform")
        {
            transform.parent = col.transform;
        }


    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "movingPlatform")
        { transform.parent = null; }


    }
}
