using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunUI : MonoBehaviour
{
    public Text nameText;
    public Image gunImage;

    public GunShoot gun;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nameText.text = gun.currentGun.displayName;
        gunImage.sprite = gun.currentGun.uiSprite;
    }
}
