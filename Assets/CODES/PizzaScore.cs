using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizzaScore : MonoBehaviour {

    public Text text;
    int score;
    int score2 = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "score: " + score2.ToString();
        score = score2;
    }
    public void NewScore() {
        score2 = score +1;
    }
}

