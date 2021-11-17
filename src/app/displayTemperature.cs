using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayTemperature : MonoBehaviour
{
    static int minTemperature = -10;
    static int maxTemperature = 110;
    static int interval = 30;

    public int currentTemperature = 75;

    // Color Related Variables
    Color currentColor = new Color32();

    public int r = 0;
    public int g = 0;
    public int b = 0;

    // Unity Objects
    public Text text_temperature;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getTemperature();
        updateColorGradient();
        text_temperature.text = currentTemperature + "°F";
    }

    // Read the temperature from the IRL Temperature Sensor
    void getTemperature()
    {
        currentTemperature = // Get temperature from the sensor...
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
}
