using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speedJump = 50f, checkRadius = 0.2f;
    private Animator anim;
    public bool isGrounded, flip;
    public Transform checkGround;
    public LayerMask whatIsGround;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(checkGround.position, checkRadius, whatIsGround);
        flip = GetComponent<SpriteRenderer>().flipX;

        if (Input.GetMouseButton(0) && isGrounded)
        {
            anim.Play("ReadyToJump");
            speedJump += 0.25f;
            if (speedJump > 80)
                speedJump = 80;
        }
        else if (Input.GetMouseButtonUp(0) && isGrounded && !flip)
        {
            rb.AddForce(Vector2.up * speedJump + Vector2.right * speedJump/2);
            speedJump = 50f;
            anim.Play("Jump");
        }
        else if (Input.GetMouseButtonUp(0) && isGrounded && flip)
        {
            rb.AddForce(Vector2.up * speedJump + Vector2.left * speedJump/2);
            speedJump = 50f;
            anim.Play("Jump");
        }
        else if (isGrounded)
        {
            anim.Play("Idle");
        }
     
    }

   
   
}
