using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Health health = other.gameObject.GetComponentInChildren<Health>();
            if(health.currentHealth < health.maxHealth)
            {
                health.currentHealth += healthNumber;
                Destroy(gameObject);
            }
        }
    }
}
