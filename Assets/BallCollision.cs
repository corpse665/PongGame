﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
       if(other.collider.name == "kanan" || other.collider.name == "kiri"){
           GetComponent<Transform>().position = new Vector2(0,0);
       } 
    }
}
