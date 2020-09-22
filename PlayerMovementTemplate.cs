using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    AudioSource jumpsound;




    // Start is called before the first frame update
    void Start()
    {
        jumpsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void jump()
    {
        jumpsound.Play();    //this  is first
        ///gdsfgfsdg
        //////gfdsgds
    }

}



