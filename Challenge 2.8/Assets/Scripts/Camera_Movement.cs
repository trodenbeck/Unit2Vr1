using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    Transform camera;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(0.0f, 1.0f);
        camera = gameObject.transform;
        camera.Translate(move * Time.deltaTime);
    }

}
