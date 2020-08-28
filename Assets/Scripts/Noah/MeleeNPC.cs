using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class MeleeNPC : MonoBehaviour
{
  /*  private float TimeBetwAttack;
    public float startTimeBetwAttack;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;

    void Update()
    {
        if (TimeBetwAttack <= 0)
        {
            //then u can atk
            if(Input.GetKey(KeyCode.Space))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange);

                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
                //TimeBetwAttack = startTimeBetwAttack;
            }

            TimeBetwAttack = startTimeBetwAttack;
        }
        else
        {
            TimeBetwAttack -= Time.DeltaTime;
        }

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Damage Taken!");
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }



    */

}
