using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextController : MonoBehaviour
{
    public int iniScore=0;
    int currScore;
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        currScore = iniScore;
        scoreText = this.GetComponent<Text>();
        scoreText.text = "SCORE:" + currScore.ToString();
    }

    public void AddScoreAndDisplay(int score)
	{
        currScore += score;
        scoreText.text = "SCORE:" + currScore.ToString();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
