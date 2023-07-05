using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton ()
    {
        SceneManager.LoadScene("Pilih");
    }
    public void OnSettingButton ()
    {
        SceneManager.LoadScene("Setting");
    }
    public void OnQuitButton ()
    {
        Application.Quit();
    }
    public void OnMenuButton ()
    {
        SceneManager.LoadScene("Menu");
    }
}
