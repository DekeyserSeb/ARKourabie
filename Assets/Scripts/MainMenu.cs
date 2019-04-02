using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Permet de gèrer les scènes

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    //public void Permission()
    //{

    //    AndroidRuntimePermissions.Permission result = AndroidRuntimePermissions.RequestPermission("android.permission.CAMERA");
    //    if (result == AndroidRuntimePermissions.Permission.Granted)
    //        Debug.Log("We have permission to access the camera!");
    //    else
    //        Debug.Log("Permission state: " + result);
    //}

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
