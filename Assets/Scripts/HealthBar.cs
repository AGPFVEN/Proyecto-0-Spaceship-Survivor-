using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private float lol;
    public float maxHealth;
    public float currentHealth;
    public float health;
    private float healing;
    private float cronometro;
    public Image hpImage;
    public Text hpText;
    public GameObject player;


    private void Start()
    {
        hpImage.GetComponent<Image>().fillAmount = 1;
        currentHealth = maxHealth;
        healing = maxHealth;
        cronometro = 0;
        lol = 1;
    }

    public void Damage(float damageAmount)
    {
        //currentHealth -= damageAmount;
        //if (currentHealth != healing && cronometro != damageAmount)
        //{
        //    cronometro += 1f * Time.deltaTime;
        //    healing -= 1f * Time.deltaTime;
        //    healing = lol * Time.deltaTime;
        //    lol = (lol - damageAmount) / maxHealth;
        //    hpImage.GetComponent<Image>().fillAmount = lol;
        //    Debug.Log(lol + "lol");
        //    Debug.Log(healing + "healing");
        //    Debug.Log(cronometro + "cronometro");
        //    if (health <= 0)
        //    {
        //        Destroy(player);
        //    }
        //}

        health = (currentHealth - damageAmount) / maxHealth;
        health = lol;
        currentHealth = currentHealth - damageAmount;
        hpImage.GetComponent<Image>().fillAmount = lol;
        hpText.GetComponent<Text>().text = currentHealth.ToString() + "%";
        if (health <= 0)
        {
            Destroy(player);
        }
    }
}
