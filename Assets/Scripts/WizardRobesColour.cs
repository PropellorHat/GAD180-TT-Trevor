using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardRobesColour : MonoBehaviour
{
    private SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.material.SetFloat("_seedProperty", Random.Range(0f, 100f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
