using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperBound = 15.0f;
    private Balloon balloon;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>(); //reference balloon obj
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        
        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScore(balloon.scoreToGive*10);
            Destroy(gameObject);
        }
    }
}
