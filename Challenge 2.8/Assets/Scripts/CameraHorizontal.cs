using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHorizontal : MonoBehaviour
{
    Transform camera;
    public Vector2 move;

    void Update()
    {
        move = new Vector2(1.5f, 0.0f);
        camera = gameObject.transform;
        camera.Translate(move * Time.deltaTime);
    }
}
