using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ControlArriba : MonoBehaviour
{
    private float amplitud = 10.0f; 
    private float frecuencia = 1.0f;
    private Vector3 startPos;
    Transform transForm;
 
    void Start () {
        transForm = GetComponent<Transform>(); 
        startPos = transform.position;
    }
     
    void Update () {
        float x = 0;
        float y = (float) Math.Sin(Time.time * frecuencia) * amplitud;
        float z = 0;
        transform.position = startPos + new Vector3(x,y,z);        
    }

}
