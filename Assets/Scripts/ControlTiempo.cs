using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlTiempo : MonoBehaviour
{
    private float timeStart = 20;
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
        ProcesarFlujo();   
    }

    public void setOff()
    {
        timeOn = false;
    }
    
    public float getTiempo() 
    {
        return timeStart;
    }

    private void ProcesarFlujo() 
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

    public void timeOff() 
    {
        setOff();
        textBox.text = timeEnd.ToString("F2");
    }
}
