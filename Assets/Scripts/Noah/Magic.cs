using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Magic : MonoBehaviour
{

    public Transform firePoint;
    public GameObject FireBall;
    float fireRate = 1f;
    float nextFire = 1f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*ON TRIGGER ENTER/STAY **THIS IS WHEN SHOOTING STARTS
    Shoot()

    */
    public void Shoot()
    {
        if (Time.time > nextFire)
        {
            Instantiate(FireBall, firePoint.position, firePoint.rotation);
            nextFire = Time.time + fireRate;
            
        }
    }

    

}