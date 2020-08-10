using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public GameObject onHitEffect;

    public float shakeDuration, shakeMagnitude;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0f)
        {
            Destroy(gameObject);
        }
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log(gameObject.name + " took " + damage + " damage");
        if(onHitEffect != null)
        {
            Instantiate(onHitEffect, transform.position, transform.rotation);
        }
        ScreenShake.Instance.StartShake(shakeDuration, shakeMagnitude);
    }
}
