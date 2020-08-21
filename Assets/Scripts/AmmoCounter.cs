using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    private Slider slider;
    public GunShoot shootScript;

    private RectTransform rt;

    public GameObject tick;
    
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = shootScript.currentMag / 100;
    }

    public void LoadTicks()
    {
        GameObject[] ticks = GameObject.FindGameObjectsWithTag("AmmoTick");
        foreach (GameObject i in ticks)
        {
            Destroy(i);
        }
        int tickCount = Mathf.FloorToInt(100 / shootScript.currentGun.ammoCost);
        
        for (int i = 0; i < tickCount; i++)
        {
            GameObject newTick = Instantiate(tick, transform.position, transform.rotation, gameObject.transform);
        }
    }
}
