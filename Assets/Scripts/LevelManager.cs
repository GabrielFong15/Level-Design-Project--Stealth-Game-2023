using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private int highScore;
    public int score;

    public Text highScoreText;
    public Text scoreText;




    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HIGHSCORE");
        highScoreText.text = "High Score: " + highScore;

    }

    // Update is called once per frame
    void Update()
    {


        scoreText.text = "Score: " + score;


        if (highScore < score)
        {
            PlayerPrefs.SetInt("HIGHSCORE", score);
            PlayerPrefs.Save();
            highScore = score;
            highScoreText.text = "High Score: " + highScore;
        }
    }

}
