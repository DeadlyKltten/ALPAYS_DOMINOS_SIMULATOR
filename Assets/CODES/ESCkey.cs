using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ESCkey : MonoBehaviour
{
    public GameObject Panel;
    public bool open = false;

    // Use this for initialization
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed.");
            Openmenu();
        }

    }

    public void Openmenu()
    {
        Panel.SetActive(!Panel.activeSelf);
    }
}
