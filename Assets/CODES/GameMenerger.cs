using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenerger : MonoBehaviour {
    public GameObject Panel;

    public Rigidbody2D rb;
    bool stopGamee = false;
    bool F_Menu = false;

    public AudioClip JumpSound;
    AudioSource MySound;
    bool Space_sound = false;

    public AudioListener audioListener;
    public List<AudioSource> audioSources;

    public GameObject flag;
    // Use this for initialization
    void Awake() {
        MySound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update() {
        spacebar();
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
            AudioListener.pause = true;
        }

    }

    void spacebar()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Space_sound == false) {
                MySound.PlayOneShot(JumpSound, 1f);

            }
            Space_sound = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Space_sound = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "Flag")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
