using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : PickUps
{
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        // Gets script from game object and sets gameManager as the main script
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gm.AddKey(amount); // Add pickup to inventory
            Destroy(gameObject); // Destroy pickup
        }
    }
}
