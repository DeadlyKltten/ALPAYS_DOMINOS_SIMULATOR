using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenerger : MonoBehaviour {
    public GameObject Panel;

    public Rigidbody2D rb;
    bool stopGamee = false;
	bool F_Menu = false;
    public GameObject finish;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (rb.position.y < -30F)
        {
            if (stopGamee == false)
            {
                stopGamee = true;
            }
            Debug.Log("GAME OVER");
            fail();
        }

    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void fail()
    { 
		if (F_Menu == false)
            {
                F_Menu = true;
            Panel.SetActive(!Panel.activeSelf);
        }
            
    }
}
