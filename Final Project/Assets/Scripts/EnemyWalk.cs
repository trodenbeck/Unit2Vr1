using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    Transform self;
    public Vector2 move;
    void Start()
    {
        
    }

    void Update()
    {
        self = gameObject.transform;
        self.Translate(move * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<EnemyWall>())
        {
            move *= new Vector2(-1.0f, 1.0f);
        }
    }
}
