using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PilihScript : MonoBehaviour
{
    public void MulaiQuiz ()
    {
        SceneManager.LoadScene("Kuis");
    }
    public void MulaiMateri ()
    {
        SceneManager.LoadScene("Materi");
    }
    public void OnSetting ()
    {
        SceneManager.LoadScene("Setting");
    }
    public void OnMenuButton ()
    {
        SceneManager.LoadScene("Menu");
    }
}
