using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlTiempo : MonoBehaviour
{
    private float timeStart = 10;
    private float timeEnd = 0;
    private bool timeOn = true;
    private Text textBox;
    

    void Start() 
    {            
        textBox = GameObject.Find("Temporizador").GetComponent<Text>();
        textBox.text = timeStart.ToString("F2");    
    }
    
    void Update()
    {
        if(timeOn) 
        {
            timeStart -= Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
            if(timeStart <= 0) {
                timeOff();
            }
        }                    
    }

    public float getTiempo() 
    {
        return timeStart;
    }

    public void timeOff() 
    {
        timeOn = false;
        textBox.text = timeEnd.ToString("F2");
    }
}
