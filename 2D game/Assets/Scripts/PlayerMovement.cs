using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRight = false;
	//public int playerJumpPower = 1250;
	private float moveX;

    public bool canMove;

    void Start()
    {
        canMove = true;
    }

	void Update () {
		PlayerMove();

        if(!canMove)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            return;
        }
	}
	
	void PlayerMove() {
		//Player Control
		moveX = Input.GetAxis ("Horizontal");
		//Animations

		//Player Direction
		if (moveX < 0.0f && facingRight == false) {
			FlipPlayer ();
		} else if (moveX > 0.0f && facingRight == true) {
			FlipPlayer ();
		}

		//Physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

	void FlipPlayer() {
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
}