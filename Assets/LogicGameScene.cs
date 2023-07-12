using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicGameScene : MonoBehaviour
{
    public int score = 0;
    public static int HighestScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    private bool birdIsAlive;

    void Start()
    {
        scoreText.text = "Actual score : " + score.ToString() + "\nHighest score : " + HighestScore;
    }

    void Update()
    {
        birdIsAlive = GameObject.FindGameObjectWithTag("bird").GetComponent<BirdScript>().birdIsAlive;
    }

    /*
    allow to use this function the Inspector :
    go to the GameObject associated (here "Logic Manager" ),
    click on the three dots on the Script Component (here "Logic" ),
    and down you can see the name "Increase Score". If you click on it,
    it will active the function addScore
    */
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        if (birdIsAlive == true) 
        {
            score++;
            scoreText.text = "Actual score : " + score.ToString() + "\nHighest Score : " + HighestScore;
            //to play a song
            FindObjectOfType<AudioManager>().Play("WinPointSound");
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void restartGame()
    {
        //reload the scene from the start
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("GameScene");
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        FindObjectOfType<AudioManager>().Play("DeathBirdSound");
        if (score > HighestScore)
            HighestScore = score;
        score = 0;

    }
}