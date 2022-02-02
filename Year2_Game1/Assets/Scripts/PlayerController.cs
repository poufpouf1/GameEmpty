using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;

    public float moveSpeed;
    public float jumpForce;

    private Vector2 moveInput;

    public LayerMask whatIsGround;
    public Transform groundPoint;

    private bool isGrounded;

    public SpriteRenderer bodySR;
    public SpriteRenderer headSR;
    public SpriteRenderer smileSR;
    public SpriteRenderer frontHandSR;
    public SpriteRenderer backHandSR;
    public SpriteRenderer leftLegSR;
    public SpriteRenderer rightLegSR;

    public Animator flipAnimator;
    public Animator characterAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement       
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        playerRb.velocity = new Vector3(moveInput.x * moveSpeed, playerRb.velocity.y, moveInput.y * moveSpeed);

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            characterAnimator.SetBool("isWalking", true);

        }
        else
        {
            characterAnimator.SetBool("isWalking", false);
        }

        //Groundcheck
        RaycastHit hit;
        if(Physics.Raycast(groundPoint.position, Vector3.down, out hit,3f ,whatIsGround))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

       
        //Flip the sprite according the direction
        if(!bodySR.flipX && !headSR.flipX && !smileSR.flipX && !frontHandSR.flipX && !backHandSR.flipX && !leftLegSR.flipX && !rightLegSR.flipX && moveInput.x > 0)
        {
            bodySR.flipX = true;
            headSR.flipX = true;
            smileSR.flipX = true;
            frontHandSR.flipX = true;
            backHandSR.flipX = true;
            leftLegSR.flipX = true;
            rightLegSR.flipX = true;
            flipAnimator.SetTrigger("Flip");
        }
        else if(bodySR.flipX && headSR.flipX && smileSR.flipX && frontHandSR.flipX && backHandSR.flipX && leftLegSR.flipX && rightLegSR.flipX && moveInput.x < 0)
        {
            bodySR.flipX = false;
            headSR.flipX = false;
            smileSR.flipX = false;
            frontHandSR.flipX = false;
            backHandSR.flipX = false;
            leftLegSR.flipX = false;
            rightLegSR.flipX = false;
            flipAnimator.SetTrigger("Flip");
        }
    }
}
