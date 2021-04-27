using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Lights : MonoBehaviour
{
    Light2D light;
    float fullLight = 1.0f;
    public bool on ;
    void Start()
    {
        light = GetComponent<Light2D>();        
        
    }


    public void Toggle_On(){
    
        
        on = true;
        
    }
    public void Toggle_Off(){
    
        on = false;

    }

    public void Update(){
        
        if(on){
            light.intensity += Time.deltaTime * 2f;
            light.intensity = Mathf.Clamp(light.intensity,0,fullLight);
        }else
        {
            light.intensity -= Time.deltaTime * 2f;
            light.intensity = Mathf.Clamp(light.intensity,0,fullLight);
        }


    }


}
