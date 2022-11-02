using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveVert : MonoBehaviour
{
    Vector2 move;
    Transform Enemy1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(0.0f, -1.0f);
        transform.Translate(move * Time.deltaTime);
    }
}
