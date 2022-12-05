using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Transform player;
    public Vector2 xMove;
    Animator animator;
    Rigidbody2D playerBody;
    public float jump;
    public static int lives;

    void Start()
    {
        animator = GetComponent<Animator>();
        playerBody = GetComponent<Rigidbody2D>();
        lives = 3;
    }

    void Update()
    {
        player = gameObject.transform;
        xMove = new Vector2(Input.GetAxis("Horizontal"), 0.0f);
        if (Input.GetAxis("Horizontal") > 0) 
        {
            player.localScale = new Vector2(4.0f, 4.0f);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            player.localScale = new Vector2(-4.0f, 4.0f);
        }
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && playerBody.velocity.y <= 0)
        {
          playerBody.AddForce(transform.up * jump);
          animator.SetBool("IsJumping", true);
        }
        if (lives <= 0)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER!");
            SceneManager.LoadScene("GameOver");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("IsCrouching", false);
            player.Translate(xMove * 5.5f * Time.deltaTime);
            jump = 1100f;

        }
        else
        {
            player.Translate(xMove * 8.0f * Time.deltaTime);
            jump = 700f;
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            animator.SetBool("IsJumping", false);
        }
        if (col.gameObject.tag == "Acorn")
        {
            Debug.Log("NOM NOM NOM");
        }
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("OUCH!");
            lives -= 1;
        }
        if (col.gameObject.tag == "Exit")
        {
            Debug.Log("GOOD JOB");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void OnBecameInvisible()
    {
        lives -= lives;
    }

}