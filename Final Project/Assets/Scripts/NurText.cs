using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NurText : MonoBehaviour
{
    public Text nutCountText;
    void Update()
    {
        nutCountText.text = ": " + PlayerMovement.nutCount;
    }
}
