using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Back_Button : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //SceneManager.LoadScene(0);
        Debug.Log("Current Scene index" + (SceneManager.GetActiveScene().buildIndex - 1).ToString());
    }
}
