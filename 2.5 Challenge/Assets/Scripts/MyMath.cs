using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath : MonoBehaviour
{
    int num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        num = Product(7);
        num = num * 2;
        Debug.Log(num);
    }

    int Product(int num1)
    {
        return num1;
    }
}
