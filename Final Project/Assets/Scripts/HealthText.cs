using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public Text healthText;
    void Update()
    {
        healthText.text = ": " + PlayerMovement.health;
    }
}
