using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource Jump;
    public AudioSource Death;
    public AudioSource Sword;
    


    public void PlayJump()
    {
        Jump.Play();
    }

    public void PlayDeath()
    {
        Death.Play();
    }

    public void PlaySword()
    {
        Sword.Play();
    }


   
}
