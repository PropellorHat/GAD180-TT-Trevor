using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class NpcCombat : MonoBehaviour
{

    private Rigidbody2D npc;
    public Transform Player;
    public float moveSpeed = 5f;
    private Vector2 Movement;
  
    
    

    void Start()
    {
        npc = this.GetComponent<Rigidbody2D>(); //get rigidbody2d and assign it to npc
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Combat()
    {
        Debug.Log("Combat begins");    //unity event starts this on trigger enter
        FindDistance();
        moveCharacter(Movement);
        //begin shooting
       
    }
    public void FindDistance()
    {
        Vector3 direction = Player.position - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        npc.rotation = angle;
        direction.Normalize();
        Movement = direction;
        Debug.Log("Movement found");
    }
    public void moveCharacter(Vector2 direction)
    {

        npc.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        Debug.Log("moved");

    }
  
}

