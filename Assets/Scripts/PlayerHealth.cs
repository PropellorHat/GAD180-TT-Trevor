using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : Health
{
    public UnityEvent onPlayerDeath;
    public GameObject deathPrefab;

    public override void OnDeath()
    {
        onPlayerDeath.Invoke();
        Destroy(gameObject);
        Instantiate(deathPrefab, transform.position, transform.rotation);
    }
}
