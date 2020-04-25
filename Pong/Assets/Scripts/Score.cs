using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Ball ballscript;
    public Text playerScoreTxt, AIscoreTxt , PlayerTwoScoreTxt;


    void Update()
    {
        playerScoreTxt.text = ballscript.playerScore.ToString();
        AIscoreTxt.text = ballscript.AIScore.ToString();
        PlayerTwoScoreTxt.text = ballscript.player2Score.ToString();
    }
}
