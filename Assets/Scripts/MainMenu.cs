using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Read()
    {
        Process.Start("http://www.gutenberg.org/files/8800/8800-h/8800-h.htm");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
