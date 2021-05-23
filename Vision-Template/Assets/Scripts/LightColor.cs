using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class LightColor : MonoBehaviour
{
    public Slider sliderR;
    public Slider sliderG;
    public Slider sliderB;
    // Start is called before the first frame update
    void Start()
    {
        sliderR.GetComponent<Slider>().value = 0;
        sliderG.GetComponent<Slider>().value = 0;
        sliderB.GetComponent<Slider>().value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float r = sliderR.value;
        float g = sliderG.value;
        float b = sliderB.value;
        gameObject.GetComponent<Light>().color = new Color(r,g,b,1);
    }
}
