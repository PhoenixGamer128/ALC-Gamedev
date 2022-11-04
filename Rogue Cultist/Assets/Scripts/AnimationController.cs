using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimationController : MonoBehaviour
{
    public float spd = 1f;
    public Animator animSpeed;
    public Animation anim;


    // Start is called before the first frame update
    void Start()
    {
        animSpeed = GetComponent<Animator>();

        StopAnim();
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) PlayAnim();
        if(Input.GetKeyDown(KeyCode.O)) StopAnim();
    }

    void PlayAnim()
    {
        animSpeed.speed = spd;
        Debug.Log("Animation playing...");
    }
    void StopAnim()
    {
        animSpeed.speed = 0f;
        Debug.Log("Animation stopped.");
    }

    public void PushPlay()
    {
        anim.Play();
    }

    public void PushStop()
    {
        anim.Stop();
    }
}
