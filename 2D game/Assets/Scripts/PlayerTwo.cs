using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwo : MonoBehaviour {

    //Player Health
    public Image healthBar;
    public float maxHealth = 100f;
    public static float currentHealth;
    
    //Player Movement
    public int playerSpeed = 10;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool canMove;
    private float canJump = 0f;

    void Start ()
    {
        currentHealth = maxHealth;
        canMove = true;
    }

	void Update ()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
        
        PlayerMove();
        if (!canMove)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            return;
        }

        if (currentHealth <= 0)
        {
            Die();
            canMove = false;
        }

    }
	
	void PlayerMove() {
		
		moveX = Input.GetAxis ("Horizontal");
        if (Input.GetButtonDown("Jump") && Time.time > canJump)
        {
            currentHealth -= 1f;
            Jump();
            canJump = Time.time + 1f;
        }

        if (moveX < 0.0f)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            currentHealth -= 0.01f;

        } else if (moveX > 0.0f) {
            GetComponent<SpriteRenderer>().flipX = false;
            currentHealth -= 0.01f;
        }

		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
    }

    void Die()
    {
        Debug.Log("Dead");
    }
}