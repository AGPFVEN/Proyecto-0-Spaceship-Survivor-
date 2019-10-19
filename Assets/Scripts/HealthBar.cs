﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public float health;
    private float healing;
    private float lol;
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
    }

    public void Damage(float damageAmount)
    {
        //currentHealth -= damageAmount;
        //if (currentHealth != healing && cronometro !=damageAmount)
        //{
        //    cronometro += 1f;
        //    healing -= 1f;
        //    healing = lol;
        //    lol= (lol - damageAmount) / maxHealth;
        //    hpImage.GetComponent<Image>().fillAmount = lol;
        //    Debug.Log(lol + "lol");
        //    Debug.Log(healing + );
        //    Debug.Log(cronometro);
        //}
        health = (currentHealth - damageAmount) / maxHealth;
        currentHealth = currentHealth - damageAmount;
        hpImage.GetComponent<Image>().fillAmount = health;
        hpText.GetComponent<Text>().text = currentHealth.ToString() + "%";
        if (health <= 0)
        {
            Destroy(player);
        }
    }
}
