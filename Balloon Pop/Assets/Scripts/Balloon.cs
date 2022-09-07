using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100;
    public int clicksToPop = 1;
    public float scaleToIncrease = .1f; // Scale increase after every pop

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        clicksToPop -= 1;
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clicksToPop <= 0)
        {
            Destroy(gameObject);
        }
    }
}
