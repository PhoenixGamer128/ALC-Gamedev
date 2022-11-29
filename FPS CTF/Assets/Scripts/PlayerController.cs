using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Stats")]
    public float moveSpeed;
    public float jumpForce;

    [Header("Camera Settings")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;
    private Camera camera;
    private Rigidbody rb;

    void Awake()
    {
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        CameraLook();

        if(Input.GetButtonDown("Jump"))
            PlayerJump();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;


        // Move relative to camera angle
        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;

        rb.velocity = dir;
    }

    void CameraLook()
    {
        // x and y reversed because it is the rotation axis, not real axis
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;

        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);

        // Controls the camera look rotation
        camera.transform.localRotation = Quaternion.Euler(-rotX,0,0);
        transform.eulerAngles += Vector3.up * y;
    }

    void PlayerJump()
    {
        // Ground Check
        Ray ray = new Ray(transform.position, Vector3.down);
        if(Physics.Raycast(ray,1.1f))
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
