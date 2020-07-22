using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Security.Cryptography;
using UnityEngine;

public class WizardProjectiles : MonoBehaviour
{

    float moveSpeed = 7f;
    private Rigidbody2D rb;
    public Transform Player;
    Vector2 ProjectileDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        ProjectileDirection = (Player.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(ProjectileDirection.x, ProjectileDirection.y);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }

        // Update is called once per frame
       
    }
}
