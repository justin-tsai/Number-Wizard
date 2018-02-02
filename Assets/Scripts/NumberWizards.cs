using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour
{
	// Use this for initialization
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 8;

	public Text text;

	public SpriteRenderer rend1;
	public SpriteRenderer rend2;
	public SpriteRenderer rend3;
	public SpriteRenderer rend4;
	public SpriteRenderer rend5;
	public SpriteRenderer rend6;
	public SpriteRenderer rend7;

	void Start(){
		StartGame();
	}

	void StartGame(){
		max = 1000;
		min = 1;
		NextGuess();
	}

	public void GuessHigher(){
		min = guess;
		NextGuess();
	}

	public void GuessLower(){
		max = guess;
		NextGuess();
	}

	public void NextGuess(){
		guess = Random.Range(min, max + 1);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		takeAwayLife();
		if (maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}

	void takeAwayLife(){
		switch (maxGuessesAllowed){
			case 6: rend7.enabled = false;
				break;

			case 5: rend6.enabled = false;
				break;

			case 4: rend5.enabled = false;
				break;

			case 3: rend4.enabled = false;
				break;

			case 2: rend3.enabled = false;
				break;

			case 1: rend2.enabled = false;
				break;

			case 0: rend1.enabled = false;
				break;
		}
	}
}