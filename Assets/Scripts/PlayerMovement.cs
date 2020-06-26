using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed;
    private Vector2 inputDir;
    private Vector2 mousePos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //make inputDir a new vector 2 with the x being the horizontal input and the y being the vertical input
        inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        //normalize to avoid double speed when going on angles
        inputDir = inputDir.normalized;
        
        //make the velocity the input direction in fixed update to stop framerate affecting move speed
        rb.velocity = (inputDir * moveSpeed);

        //creates a vector from the player to the mouse;
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
