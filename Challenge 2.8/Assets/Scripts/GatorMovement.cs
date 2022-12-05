using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatorMovement : MonoBehaviour
{
    Transform Gator;
    Vector2 GatorMove;
    void Start()
    {
        
    }

    void Update()
    {
        Gator = gameObject.transform;
       if (Time.deltaTime % 2 == 0)
        {
            GatorMove = new Vector2(1.0f, 0.0f);
        }
       if (Time.deltaTime % 2 != 0)
        {
            GatorMove = new Vector2(-1.0f, 0.0f);
        }
        Gator.Translate(GatorMove * Time.deltaTime);
    }
}
