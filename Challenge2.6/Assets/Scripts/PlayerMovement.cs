using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 yMove;
    Vector2 xMove;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        xMove = new Vector2(Input.GetAxis("Horizontal"), 0.0f);
        transform.Translate(xMove * Time.deltaTime);
        yMove = new Vector2(0.0f, Input.GetAxis("Vertical"));
        transform.Translate((yMove * 10) * Time.deltaTime);
        Vector2 flip = new Vector2(-1.0f, 1.0f);
        transform.localScale *= flip;

    }
}
