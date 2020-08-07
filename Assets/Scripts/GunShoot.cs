using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GunShoot : MonoBehaviour
{
    private GunSwitcher gunSwitcher;
    public Gun currentGun;

    private bool triggerDown;
    private float nextTimeToFire;

    public float reloadTime;
    private bool isReloading;
    public float currentMag;

    public int currentAmmo;

    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        gunSwitcher = GetComponent<GunSwitcher>();
        sprite = GetComponent<SpriteRenderer>();
        gunSwitcher.gunSwitched.Invoke();
        isReloading = false;
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

        if(Input.GetKeyDown(KeyCode.R) && !isReloading)
        {
            StartCoroutine(Reload());
        }

        if(Time.time >= nextTimeToFire)
        {
            if(triggerDown && !isReloading && currentMag >= currentGun.ammoCost) 
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
                    bul.GetComponent<ProjectileMove>().damage = currentGun.damage;
                }
                nextTimeToFire = Time.time + 1f / currentGun.fireRate;
                currentMag -= currentGun.ammoCost;
            }
        }

        if(currentMag <= 0f && !isReloading)
        {
            StartCoroutine(Reload());
        }
    }

    public void GunSwitched()
    {
        currentGun = gunSwitcher.avalableGuns[gunSwitcher.selectedGun];
        sprite.sprite = currentGun.gameSprite;
        nextTimeToFire = 0f;
    }

    IEnumerator Reload()
    {
        isReloading = true;
        while(currentMag < 100f && currentAmmo > 0)
        {
            yield return new WaitForSeconds(reloadTime/10f);
            currentMag += 10f;
            currentAmmo -= 1;
        }
        isReloading = false;
    }
}
