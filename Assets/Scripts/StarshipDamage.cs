using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StarshipDamage : MonoBehaviour
{
    public Transform character;
    public Transform HBImage;
    public Transform HBText;
    public float maxHealth;
    public float currentHealth;
    public float health;

    private void Start()
    {
        HBImage = gameObject.transform.GetChild(0).GetChild(0);
        HBText = gameObject.GetComponentInChildren<Text>().transform;
        currentHealth = maxHealth;
    }

    public void Damage(float damageAmount)
    {
        health = (currentHealth - damageAmount) / maxHealth;
    }
}
