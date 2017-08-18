using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenn : MonoBehaviour {
 
	public string Scene;
	public void LoadScene(){
		SceneManager.LoadScene (Scene);
	}

}
