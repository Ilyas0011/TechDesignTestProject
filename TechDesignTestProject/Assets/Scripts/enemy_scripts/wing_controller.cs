using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wing_controller : MonoBehaviour
{
    Animator anim;
    [SerializeField] ui_controller uiScript;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        anim.Play("wing_flight_animation");
        uiScript.PlayButtonAnimation();

    }
}
