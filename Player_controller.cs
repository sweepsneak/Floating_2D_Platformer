using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f; //max speed the player can move
    public float jumpSpeed = 10f; //max speed the player can jump
    public float moveSpeedAxis; //stores axis for movement speed
    public float jumpSpeedAxis; //stores axis for jump speed

    public Rigidbody2D thisChar;
}
    /*
    Rigidbody2D playerRb;

    public Transform groundChecker;
    public LayerMask whatIsGround;
    public float groundCheckRadius;

    Animator playerAnim;

    SpriteRenderer playerSprite;
    */

    // Start is called before the first frame update
    void Start()
    {

    }

/*
// Start is called before the first frame update
void Start()
{
    
    playerRb = this.gameObject.GetComponent<Rigidbody2D>();
    playerAnim = this.gameObject.GetComponent<Animator>();
    playerSprite = this.gameObject.GetComponent<SpriteRenderer>();
    playerAnim.SetFloat("isMoving", Mathf.Abs(moveSpeedAxis)); //set the isMoving parameter equal to the absolute value of the move speed axis
    
}
*/
//FixedUpdate runs in fixed time and is not tied to frames per second
private void FixedUpdate()
{
    {
        float moveSpeedAxis = Input.GetAxis("Horizontal");
        float jumpSpeedAxis = Input.GetAxis("Jump");
        if (Physics2D.OverlapCircle(groundCheckObject.position, groundRadius, whatIsGround) && jumpSpeedAxis > 0)
        {
            thisChar.AddForce(new Vector2(0, jumpSpeed));
        }


{
    float moveSpeedAxis = Input.GetAxis ("Horizontal");  
    if (moveSpeedAxis > 0)
{
        //transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        thisChar.AddForce(Vector2.right * moveSpeed);
}

    else if (moveSpeedAxis < 0)
{

}

    if (Input.GetButton("Horizontal") > 0)
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
    }

    {
    public Transform groundCheckObject; //object for the ground checker
    public LayerMask whatIsGround; //what layers comprise the ground
    public float groundRadius = 0.2f; //how big the collider radius is
    }
}
        /*
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }

        /*
        //if moving left but not facing left, flip left and reverse
        if (moveSpeedAxis < 0 && playerSprite.flipX == false)
        {
            playerSprite.flipX = true;
        }

        if (moveSpeedAxis > 0 &&) playerSprite.flipX == true)
        {
            playerSprite.flipX = false;
        }
        */
    }
}
