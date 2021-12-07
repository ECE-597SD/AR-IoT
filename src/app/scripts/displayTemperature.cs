using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Newtonsoft.Json.Linq;


public class displayTemperature : MonoBehaviour
{
    private string deviceID = "e00fce687482c84d64198d35";
    private int minTemperature = -10;
    private int interval = 30;
    public int currentTemperature = 0;
    public string temp;

    // Color Related Variables
    Color currentColor = new Color32();

    public int r = 0;
    public int g = 0;
    public int b = 0;

    // Unity Objects
    public Text text_temperature;
    //public Button button_upCloud;
    //public Button button_downCloud;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("getTemperature", 2, (float)0.5);   
    }

    // Update is called once per frame
    void Update()
    {
        updateColorGradient();
    }

    async Task getTemperature()
    {
        // Get temperature from the sensor...
        // Round to nearest tenth... http://csharphelper.com/blog/2017/01/use-bankers-rounding-and-normal-rounding-in-c/
        // currentTemperature = ...
        temp = await Helper.GetVariable(deviceID, "temp");
        currentTemperature = (int)Decimal.Parse(temp);        
        text_temperature.text = currentTemperature + "°F";
        
    }

    void updateColorGradient()
    {
        if (currentTemperature >= 110)
        {
            r = 255;
            g = 0;
            b = 0;
        }
        else if (currentTemperature >= 80)
        {
            r = 255;
            g = 255 - ((currentTemperature - minTemperature) % interval) * (255 / interval);
            b = 0;
        }
        else if (currentTemperature >= 50)
        {
            r = ((currentTemperature - minTemperature) % interval) * (255 / interval);
            g = 255;
            b = 0;
        }
        else if (currentTemperature >= 20)
        {
            r = 0;
            g = 255;
            b = 255 - ((currentTemperature - minTemperature) % interval) * (255 / interval);
        }
        else if (currentTemperature >= -10)
        {
            r = 0;
            g = ((currentTemperature - minTemperature) % interval) * (255 / interval);
            b = 255;
        }

        currentColor = new Color32((byte)r, (byte)g, (byte)b, 255);
        text_temperature.color = currentColor;
    }

    public void incrementCount()
    {      // Function for incrementing the counter; Public to allow it to be visible to the Unity project
        if (currentTemperature < 110)
        {
            currentTemperature++;
        }
    }

    public void decrementCount()
    {      // Function for decrementing the counter; Public to allow it to be visible to the Unity project
        if (currentTemperature > -10)
        {
            currentTemperature--;
        }
    }
}
