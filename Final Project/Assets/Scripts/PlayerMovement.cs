using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Transform player;
    Vector2 xMove;
    public float xSpeed;
    Animator animator;
    public float thrust;
    Rigidbody2D playerBody;
    public static float health;
    public static int nutCount;
    bool canJump;
    public Vector2 knockback;

    void Start()
    {
        animator = GetComponent<Animator>();
        playerBody = GetComponent<Rigidbody2D>();
        health = 5.0f;
        nutCount = 0;
        canJump = true;
    }

    void Update()
    {
        player = gameObject.transform;
        xMove = new Vector2(Input.GetAxis("Horizontal"), 0.0f);
        player.Translate(xMove * Time.deltaTime * xSpeed);
        if (Input.GetAxis("Horizontal") < 0)
        {
            player.localScale = new Vector2(-1.0f, 1.0f);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            player.localScale = new Vector2(1.0f, 1.0f);
        }
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && canJump == true)
        {
            playerBody.AddForce(transform.up * thrust);
            animator.SetBool("IsJumping", true);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("TitleScreen");
        }
        //Debug.Log(nutCount);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            animator.SetBool("IsJumping", false);
            canJump = true;
            animator.SetBool("IsHurt", false);
        }
        if(col.gameObject.tag == "Death")
        {
            health -= health;
        }
        if(col.gameObject.tag == "Enemy")
        {
            health -= 1;
            playerBody.AddForce(knockback);
            animator.SetBool("IsHurt", true);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground"){
            canJump = false;
        }
    }
}
