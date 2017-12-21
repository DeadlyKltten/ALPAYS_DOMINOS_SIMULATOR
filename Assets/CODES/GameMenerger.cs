using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenerger : MonoBehaviour {
    //sound system
    public List<AudioSource> audioSources;
    public AudioClip JumpSound;
    public AudioClip WinSound;
    public AudioClip DoodSound;
    public AudioClip PizzaSound;
    AudioSource MySound;
    bool Space_sound = false;
    public AudioListener audioListener;
    

    // menu pennals
    public GameObject Panel;
    public GameObject VICTORY;
    public GameObject flag;
    bool GameFin = false;

    // player clollision
    public Rigidbody2D rb;
    bool stopGamee = false;
    bool stopGamee2 = false;
    bool F_Menu = false;

    void Awake() {
        MySound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update() {
        spacebar();
        if (rb.position.y < -15F) {
            
            if (stopGamee2 == false)
            {
                stopGamee2 = true;
                MySound.PlayOneShot(DoodSound, 1f);
            }
        }
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
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "Flag")
        {
            VICTORYscreen();
            Debug.Log("Level Done");

        }
        if (collision.collider.tag == "Ground")
        {
            if (Space_sound == true)
            {
                Debug.Log("Jump reset");
                Space_sound = false;
            }
            
            
        }
        if (collision.collider.tag == "Pipe")
        {
            if (Space_sound == true)
            {
                Debug.Log("Jump reset");
                Space_sound = false;
            }
        }
    }
    public void VICTORYscreen()
        {
        if (GameFin == false) {
            Space_sound = true;
            MySound.PlayOneShot(WinSound, 1f);
            VICTORY.SetActive(!VICTORY.activeSelf);
            GameFin = true;
            Space_sound = true;
        }
         }
    public void GetPizza() {
        MySound.PlayOneShot(PizzaSound, 2f);
    }
}
