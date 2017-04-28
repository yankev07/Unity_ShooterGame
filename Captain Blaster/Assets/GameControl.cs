using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameControl : MonoBehaviour {

	public Text scoreText, gameOverText;
	int playerScore = 0;

	public void AddScore(){
		playerScore++;
		scoreText.text = playerScore.ToString ();
	}

	public void PlayerDied(){
		gameOverText.enabled = true; // Display the Game Over! Text
		scoreText.enabled = true;
		Time.timeScale = 0; // this Freezes the game
	}
}
