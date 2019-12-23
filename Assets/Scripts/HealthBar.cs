using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //private float lol;
    public float maxHealth;
    private float currentHealth;
    private float health;
    //private float healing;
    //private float cronometro;
    public Image hpImage;
    public Text hpText;
    public GameObject player;

    private void Awake ()
    {
        hpImage.fillAmount = 1;
        currentHealth = maxHealth;
        //healing = maxHealth;
        //cronometro = 0;
        //lol = 1;
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
 