using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GUI : MonoBehaviour
{
    public float buttonClicked = 0;

    public TMP_Text textTime;

    public Slider sliderTime;

    public Slider sliderCamera;

    // Start is called before the first frame update
    void Start()
    {
        if (sliderTime) sliderTime.value = Time.timeScale;
        if (sliderCamera) sliderCamera.value = Time.timeScale;
    }

    // Update is called once per frame
    void Update()
    {
        //textTime.text = "hello????";
    }

    public void ButtonClicked()
    {

        //if (buttonClicked)
        {

        }
        print("BUTTON CLICKED!!!");
    }

    public void SliderUpdated(float value)
    {
        Time.timeScale = value;
    }
}
