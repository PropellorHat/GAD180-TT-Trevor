using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public int ammoNumber;
    
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
            GunShoot shoot = other.gameObject.GetComponentInChildren<GunShoot>();
            shoot.currentAmmo += ammoNumber;
            Destroy(gameObject);
        }
    }
}
