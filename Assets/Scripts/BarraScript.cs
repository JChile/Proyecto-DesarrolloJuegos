using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraScript : MonoBehaviour
{
    Slider slider;
    Gradient gradient;
    
    
    void Start()
    {
        slider = GetComponent<Slider>();
        //
    
    }
    
    void update(){                   
    }
 

    public void setValue(float v)
    {
        slider.value = v;
    }

    public void decreaseValue(float v)
    {
        slider.value -= v;
    }
}
