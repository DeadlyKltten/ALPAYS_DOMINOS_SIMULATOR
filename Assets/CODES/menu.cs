using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

    public void playgame()
    {
        SceneManager.LoadScene("level1");
    }

    public void Quitgame()
    {
        Application.Quit();
    }

    public void Backgame()
    {
        Application.Quit();
    }

    public void GameRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameGoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
	public void GameGolevels()
    {
        SceneManager.LoadScene("levels");
    }
}
