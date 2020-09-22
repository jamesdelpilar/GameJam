using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollision : MonoBehaviour
{

    public int ScoreUp;

    AudioSource deathsound;
    void Start()
    {
        deathsound = GetComponent<AudioSource>();

    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            Debug.Log("Retry Screen");
            deathsound.Play();
            SceneManager.LoadScene(2);
            
        
        }
         // This means loading start menu since startmenu = 0. Once Minh sends game over 
    }                                   //have it at SceneManager.LoadScene(2);
}
