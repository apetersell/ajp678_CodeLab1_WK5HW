using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int galScore; 
	public static int guyScore; 
	public static ScoreManager scoreCard; 
	GameObject galText;
	GameObject guyText;
	Text galScoreDisplay;
	Text guyScoreDisplay;

	// Use this for initialization
	void Start () {
		galText = GameObject.Find ("Gal Text");
		guyText = GameObject.Find ("Guy Text");
		galScoreDisplay = galText.GetComponent<Text> ();
		guyScoreDisplay = guyText.GetComponent<Text> ();

		if (scoreCard == null){ 
			scoreCard = this;  
			DontDestroyOnLoad (this);
		}
		else
		{
			Destroy (gameObject);
		}
	}
		
	
	// Update is called once per frame
	void Update () {

		Debug.Log ("Gal Score: " + galScore);
		Debug.Log ("Guy Score: " + guyScore); 
		galScoreDisplay.text = galScore.ToString ();
		guyScoreDisplay.text = guyScore.ToString ();

		
	}

	public void scorePoints (int sentValue)
	{
		if (sentValue == 1) 
		{
			galScore++;
		}

		if (sentValue == 2) 
		{
			guyScore++;
		}
	}
}
