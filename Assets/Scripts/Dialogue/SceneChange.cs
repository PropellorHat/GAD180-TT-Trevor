using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(2);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            NextScene();
        }
    }
}
