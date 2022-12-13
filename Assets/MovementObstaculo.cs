using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovementObstaculo : MonoBehaviour
{
    float angle = 4*(float)(Math.PI);
    float moveSpeed =49; 
    float radius=30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //angle += moveSpeed * Time.deltaTime;
        angle += (moveSpeed / (radius * 2*((float)Math.PI))) * Time.deltaTime;
        transform.position = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * radius;  
              
    }
}
