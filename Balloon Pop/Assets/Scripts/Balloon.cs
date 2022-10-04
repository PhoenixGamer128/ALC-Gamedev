using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 1;
    public int clicksToPop = 1;
    public float scaleToIncrease = .1f; // Scale increase after every pop
    private ScoreManager scoreManager; // scoreManager is just a new name

    // Start is called before the first frame update
    void Start()
    {
        // Look for the object and get the ScoreManager script
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        clicksToPop -= 1;
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clicksToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive*5)
            Destroy(gameObject);
        }
    }
}
