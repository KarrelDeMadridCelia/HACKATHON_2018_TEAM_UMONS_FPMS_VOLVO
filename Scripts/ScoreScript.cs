using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public Text scoreText;
    public int score = 0;
    public float scoreTimer;
    public float scoreDelayTimer = 0.5f;

	// Use this for initialization
	void Start ()
    {

        scoreText.text = score.ToString();
        scoreTimer = scoreDelayTimer;
	}
	
	// Update is called once per frame
	void Update ()
    {

        scoreTimer -= Time.deltaTime;
        if (scoreTimer < 0)
        {
            score = score + 10;
            scoreTimer = scoreDelayTimer;
            scoreText.text = "Points : "+ score.ToString();

        }
	}
}
