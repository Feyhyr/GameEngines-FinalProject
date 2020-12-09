﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void SwitchToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Debug.Log("Game has quit :3");
        Application.Quit();
    }

    public void DestroyCharacter()
    {
        Destroy(GameObject.Find("Character"));
    }
}