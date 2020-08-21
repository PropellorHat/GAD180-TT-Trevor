using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public Gun gun;

    private SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        sprite.sprite = gun.uiSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            GunSwitcher switcher = other.gameObject.GetComponentInChildren<GunSwitcher>();
            if (!switcher.avalableGuns.Contains(gun))
            {
                switcher.avalableGuns.Add(gun);
                switcher.selectedGun = switcher.avalableGuns.Count - 1;
                switcher.gunSwitched.Invoke();
                Debug.Log("added" + gun.displayName);
            }
            Destroy(gameObject);
        }
    }
}
