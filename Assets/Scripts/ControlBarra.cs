using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlBarra : MonoBehaviour
{
    Slider slider;
    Image image;  
    [SerializeField] Gradient gradient;
    
    private float velCom = 4f;   
    
    void Start() 
    {
        slider = GetComponent<Slider>();            
        image = GameObject.Find("Contenido").GetComponent<Image>();;
    }
     
    public void setValue(float v) 
    {
        slider.value = v;
        setColor();
    }

    public float getValue() 
    {
        return slider.value;
    }

    public void decrementValue()
    {        
        slider.value -= velCom * Time.deltaTime;    
        setColor();
    }

    public void setColor(){
        image.color = gradient.Evaluate(slider.normalizedValue);
    }

    
}
