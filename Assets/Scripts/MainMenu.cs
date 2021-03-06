﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Permet de gèrer les scènes
using UnityEditor;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image Loader;
    public Image Fade;
    public Image Static;
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }


    public void PlayGame()
    {

        StartCoroutine(LoadAsync(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

        Fade.gameObject.SetActive (false);
        Static.gameObject.SetActive(false);
        Loader.gameObject.SetActive(true);

        while (!operation.isDone)
        {
            Debug.Log(operation.progress);
                yield return null;
        }
    }


    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();

    }

    public void OpenWebSite()
    {
        Application.OpenURL("https://www.chrisanthidis.gr/en/");
    }
}
