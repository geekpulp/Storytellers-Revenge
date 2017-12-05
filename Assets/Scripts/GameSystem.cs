using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour {

public Text scoreText;
public int score;

	// Use this for initialization
	void Start () {
		score = 0;
		updateScore (0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

public void addScore (int newScoreValue)
{
	if (score <	4)
	    {
		  updateScore (newScoreValue);
		}
}
void updateScore (int newScore)
{
	score += newScore;
	scoreText.text = score + " of 4 found";
}

}

