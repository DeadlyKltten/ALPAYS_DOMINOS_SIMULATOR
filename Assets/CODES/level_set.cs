using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_set : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Bootback()
    {
        SceneManager.LoadScene("Menu");
    }
    public void BootLev1()
    {
        SceneManager.LoadScene("level1");
    }
    
}
