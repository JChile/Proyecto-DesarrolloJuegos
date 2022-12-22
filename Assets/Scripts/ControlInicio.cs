using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlInicio : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        } 
    }
}
