using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	public enum player {
		One = 1,
		Two = 2
	}

	public player p;
	public Text t;
	// Use this for initialization
	void Start () {
		t = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (p == player.One) {
			
		} else if(p == player.Two){

		}
	}
}
