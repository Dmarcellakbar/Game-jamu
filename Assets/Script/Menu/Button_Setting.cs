using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Setting : MonoBehaviour
{
    public void OnMenuButton ()
    {
        SceneManager.LoadScene("Menu");
    }
}
