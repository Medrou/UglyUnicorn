using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public static int scoreValue = 0;
    Text score;
    public Text highScore;

    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
        highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
        //score.text = scoreValue.ToString();

        if (scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreValue);
            highScore.text = scoreValue.ToString();
        }
    }
}
