using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.y < 0) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
