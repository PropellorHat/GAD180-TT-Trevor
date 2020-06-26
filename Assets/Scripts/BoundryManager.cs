using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundryManager : MonoBehaviour
{
    private BoxCollider2D managerBox; //box collider of the camera boundry
    private Transform player;
    public GameObject boundry; //the specific boundry this is a parent to
    
    // Start is called before the first frame update
    void Start()
    {
        managerBox = GetComponent<BoxCollider2D>();

        //i would do this in inspector but it would be a hassle to do for every boundry
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //check if the player's position is within the bounds of the managerBox
        if(managerBox.bounds.min.x < player.position.x && player.position.x < managerBox.bounds.max.x &&
           managerBox.bounds.min.y < player.position.y && player.position.y < managerBox.bounds.max.y)
        {
            boundry.SetActive(true);
        }
        else
        {
            boundry.SetActive(false);
        }
    }
}
