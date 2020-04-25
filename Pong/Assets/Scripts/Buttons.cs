using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public static bool singleplay, multiplay;

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SinglePlaying()
    {
        singleplay = true;
        SceneManager.LoadScene("SampleScene");
    }

    public void MultiPlaying()
    {
        multiplay = true;
        SceneManager.LoadScene("MultiplayerScene");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
