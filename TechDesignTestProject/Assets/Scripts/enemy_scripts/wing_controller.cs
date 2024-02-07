using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wing_controller : MonoBehaviour
{
    Animator anim;
    [SerializeField] ui_controller uiScript;
    [SerializeField] AudioSource jumpAudio;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        anim.Play("wing_flight_animation");
        uiScript.PlayButtonAnimation();
        jumpAudio.Play();

    }
}
