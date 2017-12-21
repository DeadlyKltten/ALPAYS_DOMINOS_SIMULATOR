using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    bool score = false;
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
    }
    private void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            if (score == false) {
                FindObjectOfType<PizzaScore>().NewScore();
                score = true;
            }
            FindObjectOfType<PizzaScore>().NewScore();
			FindObjectOfType<GameMenerger>().GetPizza();
            score = false;
            Destroy(gameObject);
        }
    }
}
