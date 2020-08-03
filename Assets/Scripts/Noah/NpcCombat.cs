using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCombat : MonoBehaviour
{

    private Rigidbody2D rb;
    public Transform target;
    public float moveSpeed;
    private Vector2 movement;

    public GameObject trigger;

    public Transform firePoint;
    public GameObject FireBall, chargeBall;
    public float fireRate = 2f;
    private float nextFire;
    private bool canShoot = true;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //get rigidbody2d and assign it to npc
        nextFire = Time.time + fireRate + Random.Range(-fireRate / 2, fireRate / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.activeInHierarchy == true)
        {
            Combat();
        }
    }

    public void Combat()
    {
        FindDistance();
        MoveCharacter(movement);
        if(canShoot)
        {
            TestForShoot();
        }
    }
    public void FindDistance()
    {
        Vector3 direction = target.position - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    public void MoveCharacter(Vector2 direction)
    {

        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));

    }

    public void TestForShoot()
    {
        if (Time.time >= nextFire)
        {
            StartCoroutine(Shoot());
            
        }
    }

    public IEnumerator Shoot()
    {
        canShoot = false;
        GameObject charge = Instantiate(chargeBall, firePoint);
        yield return new WaitForSeconds(0.7f);
        Destroy(charge);
        Instantiate(FireBall, firePoint.position, firePoint.rotation);
        nextFire = Time.time + fireRate + Random.Range(-fireRate / 2, fireRate / 2);
        canShoot = true;
    }
}

