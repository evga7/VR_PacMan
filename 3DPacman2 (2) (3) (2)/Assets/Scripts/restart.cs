using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

	public void button_click()
	{
		SceneManager.LoadScene(1);
		SceneManager.LoadScene(2,LoadSceneMode.Additive);
	}
}
