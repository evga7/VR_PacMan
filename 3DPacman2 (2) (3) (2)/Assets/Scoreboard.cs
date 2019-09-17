using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scoreboard : MonoBehaviour {
	public Text ScoreTxt;
	int Score;
	// Use this for initialization
	void Start () {
		Score = coinmanager.instance.m_score;
		if (Score >= 12000)
			ScoreTxt.text = "Score : " + Score + "\n" + "Grade : A+";
		else if (Score >= 10000)
			ScoreTxt.text = "Score : " + Score + "\n" + "Grade : A";
		else if (Score >= 80000)
			ScoreTxt.text = "Score : " + Score + "\n" + "Grade : B";
		else if (Score>=5000)
			ScoreTxt.text = "Score : " + Score + "\n"+"Grade : C";
		else if (Score>=2000)
			ScoreTxt.text = "Score : " + Score + "\n"+"Grade : D";
		else 
			ScoreTxt.text = "Score : " + Score + "\n"+"Grade : F";
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
