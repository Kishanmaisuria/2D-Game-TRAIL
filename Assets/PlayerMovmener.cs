using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovmener : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;
    public AudioSource audioSource;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    bool Crouch = false;
    
    

    // Update is called once per frame
    void Update()
    {
        
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        audioSource = GetComponent<AudioSource>();

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("Jumping", true);
            audioSource.Play();
        }

    

    }
    public void Onlanding() 
    {

        animator.SetBool("Jumping", false);
    }
    

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime,Crouch,jump);
        jump = false;

    }
};
