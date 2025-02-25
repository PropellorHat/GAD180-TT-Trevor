﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public GameObject onHitEffect;

    public float shakeDuration, shakeMagnitude;

    private GameManagerScript gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        currentHealth = maxHealth;
        gameManagerScript.allEnemies.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0f)
        {
            OnDeath();
        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log(gameObject.name + " took " + damage + " damage");
        if (onHitEffect != null)
        {
            Instantiate(onHitEffect, transform.position, transform.rotation);
        }
        ScreenShake.Instance.StartShake(shakeDuration, shakeMagnitude);
    }

    public void OnDeath()
    {
        gameManagerScript.allEnemies.Remove(gameObject);
        Destroy(gameObject);
    }
}
