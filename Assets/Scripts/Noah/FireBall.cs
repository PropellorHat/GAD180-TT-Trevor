using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{


    public float speed = 10f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    public void OnTriggerEnter2D(Collider2D Collider)
    {
        
        if (Collider.gameObject.tag == "wall")
        {
            
            Destroy(gameObject); //destroys on some walls and goes through others?
        }
        if (Collider.gameObject.name == "Player")
        {
            Debug.Log("BEEEEEM");
           
            Destroy(gameObject);
        }
         if (Collider.gameObject.tag == "Bullet")
         {


             Destroy(gameObject);
         }
        
      

    }
    


}
