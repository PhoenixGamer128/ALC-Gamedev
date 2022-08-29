using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string playerName = "Kirby";

    public int speed; // Set directional speed
    public float rotSpeed;
    public float hInput; // Variable for horizontal input
    public float vInput; // Variable for vertical input

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal"); // Input from keyboard
        vInput = Input.GetAxis("Vertical"); // Input from keyboard

        // Player move code along horizontal plane
        transform.Rotate(Vector3.up, rotSpeed * speed * hInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime);
    }
}
