using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float hInput;
    public float vInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * hInput * speed * Time.deltaTime);
        transform.Translate(Vector2.up * vInput * speed * Time.deltaTime);
    }
}
