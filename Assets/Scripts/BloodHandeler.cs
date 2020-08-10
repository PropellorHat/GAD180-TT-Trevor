using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodHandeler : MonoBehaviour
{
    public GameObject[] bursts;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject burst in bursts)
        {
            burst.transform.Rotate(new Vector3(0, 0, Random.Range(0f, 360f)));
        }

        Destroy(gameObject, 1f);
    }
}
