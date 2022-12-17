using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlItem : MonoBehaviour
{
    
    private float velGir = 100f;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.up * velGir * Time.deltaTime);
    }

}
