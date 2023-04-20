using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth = 100;

    public TextMeshProUGUI healthTextField;
    //public string healthText;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }


    public void AdjustHealth(Component sender, object data)
    {
        if (data is int)
        {
            health = health + (int)data;
        }
        UpdateHeatlhDisplay(health);
    }

    private void UpdateHeatlhDisplay (int health)
    {
        healthTextField.text = ("Health: " + health.ToString());
    }
}
