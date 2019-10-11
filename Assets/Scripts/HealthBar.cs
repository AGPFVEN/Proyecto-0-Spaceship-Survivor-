using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public float health;
    public Image hpImage;
    public Text hpText;


    private void Start()
    {
        hpImage.GetComponent<Image>().fillAmount = 1;
        currentHealth = maxHealth;
    }

    public void Damage(float damageAmount)
    {
        health = (currentHealth - damageAmount) / maxHealth;
        currentHealth = currentHealth -damageAmount;
        hpImage.GetComponent<Image>().fillAmount = health;
        hpText.GetComponent<Text>().text = currentHealth.ToString() + "%";
        if (health <= 0)
        {
            hpImage.GetComponent<Text>().text = "0";
        }
    }
}
