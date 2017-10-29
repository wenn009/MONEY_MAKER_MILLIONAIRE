using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMangement : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeScene(){
		Debug.Log("change scene");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}

	public void ReturnBackAScene() {
		Debug.Log ("return");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}
}
