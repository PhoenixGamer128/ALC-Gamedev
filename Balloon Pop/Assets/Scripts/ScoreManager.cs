using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText; // Text UI object to be modified
    // Start is called before the first frame update

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
