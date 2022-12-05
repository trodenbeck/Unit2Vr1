using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntBehaviour : MonoBehaviour
{
    Transform ant;
    Vector2 AntMove;
    float speed;

    void Start()
    {
        
    }

    void Update()
    {
        ant = gameObject.transform;
        speed = -0.5f;
        AntMove = new Vector2(speed, 0.0f);
        ant.Translate(AntMove * Time.deltaTime);
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Debug.Log("FLIP");
            if (speed > 0)
            {
                speed = -0.5f;
            }
            if (speed < 0)
            {
                speed = 0.5f;
            }
        }
    }
}
