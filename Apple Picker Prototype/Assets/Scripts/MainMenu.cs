using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGameEasy()
    {
        SceneManager.LoadScene("Scene_0");
    }

    public void PlayGameMedium()
    {
        SceneManager.LoadScene("Scene_1");
    }
}
