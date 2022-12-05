using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform player;
    Vector2 xMove;
    Rigidbody2D playerBody;
    float jumpForce;
    Vector2 flip;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //OnCollisionEnter2D(player);
        xMove = new Vector2(Input.GetAxis("Horizontal"),0.0f);
        player = gameObject.transform;
        player.Translate(xMove * 5 * Time.deltaTime);
        jumpForce = 500f;
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            playerBody.AddForce(transform.up * jumpForce);
            animator.SetBool("jumpTrigger", true);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            player.localScale = new Vector2(4.0f, 4.0f);
           animator.SetBool("RunTrigger", true);
        }
        else if (Input.GetAxis("Horizontal") < 0){
            player.localScale = new Vector2(-4.0f,4.0f);
           animator.SetBool("RunTrigger", true);
        }else
        {
           animator.SetBool("RunTrigger", false);
        }
    }
    public void OnCollisionEnter2D(Collision2D gameObject)
    {
        animator.SetBool("jumpTrigger", false);
    }
}
