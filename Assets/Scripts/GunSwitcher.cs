using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GunSwitcher : MonoBehaviour
{
    public List<Gun> avalableGuns;
    public int selectedGun = 0;
    public UnityEvent gunSwitched;

    private SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        int previousGun = selectedGun;

        //handle the switching of weapons with the scroll wheel
        if (Input.mouseScrollDelta.y > 0)
        {
            if(selectedGun >= avalableGuns.Count - 1)
            {
                selectedGun = 0;
            }
            else
            {
                selectedGun++;
            }
        }

        if (Input.mouseScrollDelta.y < 0)
        {
            if (selectedGun <= 0)
            {
                selectedGun = avalableGuns.Count - 1;
            }
            else
            {
                selectedGun--;
            }
        }

        //run the gun switched event if the selected gun has changed
        if (previousGun != selectedGun)
        {
            gunSwitched.Invoke();
        }
    }
}
