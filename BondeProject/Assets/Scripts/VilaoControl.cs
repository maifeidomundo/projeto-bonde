﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VilaoControl : MonoBehaviour
{
   

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Water"))
        {
          
         
         Destroy(gameObject);
            
            
        
        }


    }
}