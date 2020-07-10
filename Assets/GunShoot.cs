using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    private GunSwitcher gunSwitcher;
    public Gun currentGun;

    private string displayName;
    private Sprite gameSprite;

    private GameObject projectile;
    private bool automatic;
    private float fireRate;

    private float projectileCount;
    private float spread;

    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        gunSwitcher = GetComponent<GunSwitcher>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GunSwitched()
    {
        currentGun = gunSwitcher.avalableGuns[gunSwitcher.selectedGun];
        sprite.sprite = currentGun.gameSprite;
    }
}
