using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovmentHorizontal : MonoBehaviour
{
    Vector2 move;
    Transform Enemy3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(-1.0f, 0.0f);
        transform.Translate(move * Time.deltaTime);
    }
}
