using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoomTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public bool TriggerCheck; //collision is true
    public UnityEvent TriggerEntered;
    public List<GameObject> specificGameObjects;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D Collider)
    {
        UnityEngine.Debug.Log("Triggered");
        if (Collider.gameObject.name == "Player")
        {
            Debug.Log("Floor is Triggered");
            this.TriggerEntered.Invoke();

        }

    }

   private void OnTriggerStay2D(Collider2D Collider)
    {
        Debug.Log("Floor is Triggered 2");
        if (Collider.gameObject.name == "Player")
        {
            Debug.Log("Floor is Triggered");
            this.TriggerEntered.Invoke();

        }
    }
   
}


