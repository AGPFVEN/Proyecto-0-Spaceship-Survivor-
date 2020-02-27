using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float maxHealth;
    private float currentHealth;
    private float health;
    public Image hpImage;
    public Text hpText;
    public GameObject player;

    private void Awake ()
    {
        hpImage.fillAmount = 1;
        currentHealth = maxHealth;
    }

    public void Damage(float damageAmount)
    {
        //Este es el que funciona
        health = (currentHealth - damageAmount) / maxHealth;
        currentHealth = currentHealth - damageAmount;
        hpImage.GetComponent<Image>().fillAmount = currentHealth/maxHealth;
        hpText.GetComponent<Text>().text = currentHealth.ToString() + "%";
        if (health <= 0)
        {
            Destroy(player);
        }
    }
}