using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyBoxSlideChanger : MonoBehaviour
{
    [SerializeField] public Material MorningSkybox;
    [SerializeField] public Material DaySkybox;
    [SerializeField] public Material AfternoonSkybox;
    [SerializeField] public Material NightSkybox;

    [SerializeField] public Slider TimeOfDaySlider;
   
    // Start is called before the first frame update
    void Start()
    {
        TimeOfDaySlider.minValue = -25f;
        TimeOfDaySlider.maxValue = 260f;
        TimeOfDaySlider.wholeNumbers = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeOfDaySlider.value <= 20f)
        {
            RenderSettings.skybox = MorningSkybox;
            
        }
        if (TimeOfDaySlider.value >= 65f)
        {
            RenderSettings.skybox = DaySkybox;
        }
        if (TimeOfDaySlider.value >= 150f)
        {
            RenderSettings.skybox = AfternoonSkybox;
        }
        if (TimeOfDaySlider.value >= 240f)
        {
            RenderSettings.skybox = NightSkybox;
        }
        
    }
}
