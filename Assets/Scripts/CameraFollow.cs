using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    private BoxCollider2D cameraBox; //box collider of the camera
    private Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraBox = GetComponent<BoxCollider2D>();

        FindTarget();
    }

    // Update is called once per frame
    void Update()
    {
        //see if there is a boundry active (by the player being in it)
        if(GameObject.Find("CameraBoundry"))
        {
            //put that box collider into a temp variable
            BoxCollider2D currentBoundry = GameObject.Find("CameraBoundry").GetComponent<BoxCollider2D>();

            //move the camera to the players position within the bounds of the cameraBound
            //give or take a margin of half the camera's box to compensate for the pivot being in the center
            transform.position = new Vector3(Mathf.Clamp(player.position.x, currentBoundry.bounds.min.x + cameraBox.size.x / 2, currentBoundry.bounds.max.x - cameraBox.size.x / 2), Mathf.Clamp(player.position.y, currentBoundry.bounds.min.y + cameraBox.size.y / 2, currentBoundry.bounds.max.y - cameraBox.size.y / 2), transform.position.z);
        }
    }

    public void FindTarget()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
}
