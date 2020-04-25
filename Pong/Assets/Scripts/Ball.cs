using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public int playerScore, player2Score;
    public int AIScore;
    public bool playerWon = false;
    public bool player2Won = false;
    public bool AIWon=false;
    public GameObject GameSingle, GameMultiplayer, UI;

    public AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        Launch();
        audioSrc = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (playerScore == 5)
        {
            playerWon = true;

            GameSingle.SetActive(false);
            GameMultiplayer.SetActive(false);
            UI.SetActive(true);

            playerScore = 0;
        }
        if (AIScore == 5)
        {
            AIWon = true;
            // SceneManager.LoadScene("ShowScores");

            GameSingle.SetActive(false);
            GameMultiplayer.SetActive(false);
            UI.SetActive(true);

            AIScore = 0;
        }

        if (player2Score == 5)
        {
            player2Won = true;
            // SceneManager.LoadScene("ShowScores");

            GameSingle.SetActive(false);
            GameMultiplayer.SetActive(false);
            UI.SetActive(true);

            player2Score = 0;
        }
    }

    void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerScores")
        {
            playerScore += 1;
            audioSrc.Play();
            StartCoroutine(RestartPos(1));
        }

        if (collision.tag == "AIScores")
        {
            AIScore += 1;
            audioSrc.Play();
            StartCoroutine(RestartPos(1));
        }

        if(collision.tag == "PlayerTwoScores"){
            player2Score += 1;
            audioSrc.Play();
            StartCoroutine(RestartPos(1));
        }
    }
   

    IEnumerator RestartPos(float time)
    {
        yield return new WaitForSeconds(time);
        transform.position = new Vector2(0f, 0f);
    }
}
