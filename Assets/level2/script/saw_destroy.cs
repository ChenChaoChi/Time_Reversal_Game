﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw_destroy : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "spike"){
            Destroy(col.gameObject);
        }
    }
}
