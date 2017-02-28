using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class ScoreManager : MonoBehaviour {

	public static int galScore; 
	public static int guyScore; 
	public static ScoreManager scoreCard; 

	// Use this for initialization
	void Start () {

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
