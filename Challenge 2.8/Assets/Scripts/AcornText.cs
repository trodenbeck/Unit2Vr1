using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcornText : MonoBehaviour
{
    public Text acornText;
    void Update()
    {
        acornText.text = ": " + Acorn_Collection.AcornCount;
    }
}
