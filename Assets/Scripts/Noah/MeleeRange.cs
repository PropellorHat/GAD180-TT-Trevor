using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;


public class MeleeRange : MonoBehaviour
{


    public float TargetRange = 3f;
    private Rigidbody2D rb;

    public Animator animator;
    public float dist;
    public GameObject Target;
    private Transform player;



    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }



    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.position, Target.transform.position);
        if (dist < 2.0f)
        {
            Attack();
        }
        /* if (Input.GetKeyDown(KeyCode.Space))
             {
                 Attack();
                 Debug.Log(" space is pressed");
             }
        

             if (trigger.activeInHierarchy == true)
                {
                    Attack();
                }
       */





    }




    public void Attack()
    {
        animator.SetTrigger("attack");
        Debug.Log("Melee initiated");

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") //if it hits enemy npc
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
            
        }
    }
}
