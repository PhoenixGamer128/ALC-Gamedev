using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagScript : MonoBehaviour
{
    private GameManager gm;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        // Find GameManager object, then get its script component
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gm.hasFlag = true;
            Debug.Log("You have taken control of the flag!");
            rend.enabled = false;
        }
    }
}
