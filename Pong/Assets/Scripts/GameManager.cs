using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text WinLoseTxt;
    public static bool isSinglePlayer = false, isMultiPlayer= false;
    public Ball ballscript;
   

    void Update()
    {
        if(ballscript.playerWon)
        {
            WinLoseTxt.text = "YOU WON";
            ballscript.playerWon = false;
        }
        if(ballscript.AIWon)
        {
            WinLoseTxt.text = "YOU LOST";
            ballscript.AIWon = false;
        }
        else if (ballscript.player2Won)
        {
            WinLoseTxt.text = "Player 2 WON";
            ballscript.player2Won = false;
        }

        if (Buttons.singleplay)
        {
            Buttons.singleplay = false;
        }
        else if (Buttons.multiplay)
        {
            Buttons.multiplay = false;
        }
    }


}
