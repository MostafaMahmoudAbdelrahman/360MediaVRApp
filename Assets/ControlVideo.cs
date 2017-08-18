using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;
using UnityEngine.UI;

public class ControlVideo : MonoBehaviour {

	public MediaPlayer  M;
	public Slider S;

    //methode Play button
	public void PLAY(){
		M.Play ();
	}
    //methode Pause button
    public void PAUSE(){
		M.Pause ();
	}
    //methode Restart button
	public void RESTART(){
		M.Control.Rewind();
		S.value = 0;
	}
    //methode Slider  button
	public void TRANSACTION(float time){
		Debug.Log (S.value);
		M.Control.Seek(S.value*time);

	}
	void Update () {
		if (S.value >= 10) {
			S.value = 0;
		}
	}
}
