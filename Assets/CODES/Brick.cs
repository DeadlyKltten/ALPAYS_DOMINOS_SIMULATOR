using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public GameObject Pizza;


    private void OnCollisionEnter2D(Collision2D Other) { 
        if (Other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(Pizza, transform.position, Quaternion.identity);
        }
    }

}

