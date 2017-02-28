using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class StageBuilder : MonoBehaviour {

	public GameObject playerGuy; 
	public GameObject playerGal; 
	public GameObject block; 
	public string [] fileNames;
	public static int stageNum; 


	// Use this for initialization
	void Start () {
		string fileName = fileNames [stageNum];
		string filePath = Application.dataPath + "/" + fileName; 

		StreamReader sr = new StreamReader (filePath);

		int yPos = 0;

		while(!sr.EndOfStream)
		{
			string line = sr.ReadLine(); 

			for(int xPos = 0; xPos < line.Length; xPos++) 
			{

				if(line[xPos] == 'X')
				{ 

				}

				if (line [xPos] == 'B') 
				{
					 
				}
			}
			yPos--; 
		}

		sr.Close();
	}
		
	
	// Update is called once per frame
	void Update () {
		
	}
}
