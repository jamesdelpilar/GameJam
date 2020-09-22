using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_an_object : MonoBehaviour
{
    // values can be adjusted later!
    public float objectSpeedX = 6f; // speed moving left and right
    public float objectSpeedY = -0.5f; // moving up and down
    private Rigidbody2D rb; //"physical body"
    private Vector2 screenBounds; // out of frame

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); 
        rb.velocity = new Vector2(-objectSpeedX, objectSpeedY);
    }

    void Update()
    {
        
    }




}
