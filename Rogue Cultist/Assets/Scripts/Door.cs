using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float doorDelay = 0.5f;

    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && gm.key >= 1)
        {
            Destroy(gameObject,doorDelay);
            gm.key --;
            Debug.Log("Door opened!");
        }
        else
        {
            Debug.Log("Door is locked, you need a key...");
        }
    }

    void CheckForKey(string other)
    {
        
    }
}
