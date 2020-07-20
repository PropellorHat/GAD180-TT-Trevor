using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    private GunSwitcher gunSwitcher;
    public Gun currentGun;

    private bool triggerDown;
    private float nextTimeToFire;

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
        //get the input for automatic or not
        if(currentGun.isAutomatic)
        {
            triggerDown = Input.GetKey(KeyCode.Mouse0);
        }
        else
        {
            triggerDown = Input.GetKeyDown(KeyCode.Mouse0);
        }

        if(triggerDown)
        {
            if(Time.time >= nextTimeToFire)
            {
                float spreadAngle = currentGun.spread / currentGun.projectileCount;
                for (int i = 0; i < currentGun.projectileCount; i++)
                {
                    GameObject bul = Instantiate(currentGun.projectile, transform.position, transform.rotation);
                    if(currentGun.fixedSpread)
                    {
                        bul.transform.Rotate(0, 0, (-currentGun.spread/2) + (spreadAngle * i));
                    }
                    else
                    {
                        bul.transform.Rotate(0, 0, Random.Range(-currentGun.spread, currentGun.spread));
                    }
                }
                nextTimeToFire = Time.time + 1f / currentGun.fireRate;
            }
        }
    }

    public void GunSwitched()
    {
        currentGun = gunSwitcher.avalableGuns[gunSwitcher.selectedGun];
        sprite.sprite = currentGun.gameSprite;
        nextTimeToFire = 0f;
    }
}
