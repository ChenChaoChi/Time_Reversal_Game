﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport3_control : MonoBehaviour
{
    private Vector3 pos;
    GameObject SE;

    void Start()
    {
        SE = GameObject.Find("SEPlayer");
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name == "player"){
            pos = GameObject.Find("teleport_door4").GetComponent<Transform>().position;
            GameObject.Find("player").GetComponent<Transform>().position = pos + new Vector3(2.0f, 0.0f, 0.0f);
            SE.GetComponent<SEController>().Playenemyshoot();
        }
    }
}
