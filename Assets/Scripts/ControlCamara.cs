using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    Transform transformCam;
    Transform transformNav;
    public Vector3 disCam;
    public Vector3 nuePos;
       
    private float velCam = 0.025f;
    private Vector3 velZer = Vector3.zero;

    void Start()
    {        
        transformCam = GetComponent<Transform>(); 
        transformNav = GameObject.Find("Nave").GetComponent<Transform>();
        disCam = transformCam.position - transformNav.position;
    }

    void LateUpdate()
    {
        if (transformNav != null) {
            nuePos = transformNav.position + disCam;
            transformCam.position = Vector3.SmoothDamp(transformCam.position, nuePos, ref velZer, velCam);
        }
        
    }
}
