using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class NpcCombat : MonoBehaviour
{

    private Rigidbody2D rb;
    public Transform target;
    public float moveSpeed;
    private Vector2 movement;

    public GameObject trigger;

    public Transform firePoint;
    public GameObject FireBall;
    float fireRate = 1f;
    float nextFire = 1f;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //get rigidbody2d and assign it to npc
       
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
        Shoot();
       
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

    public void Shoot()
    {
        if (Time.time > nextFire)
        {
            Instantiate(FireBall, firePoint.position, firePoint.rotation);
            nextFire = Time.time + fireRate;

        }
    }

}

