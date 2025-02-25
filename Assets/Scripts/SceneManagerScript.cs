﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public GameObject creditsObj;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {
        creditsObj.SetActive(!creditsObj.activeInHierarchy);
    }

    public void QuitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
