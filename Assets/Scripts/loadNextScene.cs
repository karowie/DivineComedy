using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNextScene : MonoBehaviour
{
    public void nextLevelInHell()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        char last = currentScene.name[currentScene.name.Length-1];
        int number = (int)(last - '0');
        if (number==9)
        {
            Cursor.visible = true;
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(number + 2);
        }
        

    }
}
