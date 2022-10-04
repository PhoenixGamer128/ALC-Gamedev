using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int key;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    // Adds number of keys to inventory and shows a message
    public void AddKey(int amount)
    {
        key += amount;
        print("Keys = " + key); // Debug.Log("Keys = " + key;)
    }
}
