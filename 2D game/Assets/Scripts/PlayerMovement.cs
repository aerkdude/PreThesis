using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //Player Movement
    public int playerSpeed = 10;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool canMove;
    private float canJump = 0f;

    void Start ()
    {
        canMove = true;
    }

	void Update ()
    {
		PlayerMove();
        if (!canMove)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            return;
        }
	}
	
	void PlayerMove() {
		//Player Control
		moveX = Input.GetAxis ("Horizontal");
        if (Input.GetButtonDown ("Jump") && Time.time > canJump)
        {
            Jump();
            canJump = Time.time + 1f;
        }
		
        if (moveX != 0)
        {
            GetComponent<Animator>().SetBool("IsWalking", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("IsWalking", false);
        }
		//Player Direction
		if (moveX < 0.0f)
        {
            GetComponent<SpriteRenderer>().flipX = true;
	    }
        else if (moveX > 0.0f)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

		//Physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
    }
}