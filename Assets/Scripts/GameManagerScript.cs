using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public List<GameObject> allEnemies;
    private bool isDead = false;

    public GameObject deadUI, winUI;
    
    public void PlayerDeath()
    {
        isDead = true;
    }

    private void Update()
    {
        if(allEnemies.Count == 0)
        {
            winUI.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(0);
            }
        }

        if (isDead)
        {
            deadUI.SetActive(true);
            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
