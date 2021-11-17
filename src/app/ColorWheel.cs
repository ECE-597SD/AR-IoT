using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorWheel : MonoBehaviour
{
    public Image image_ColorWheel;

    public Sprite sprite_colorWheelOff;
    public Sprite sprite_colorWheelOn;
    public Sprite sprite_colorWheelOn_Yellow;
    public Sprite sprite_colorWheelOn_Orange;
    public Sprite sprite_colorWheelOn_Red;
    public Sprite sprite_colorWheelOn_Purple;
    public Sprite sprite_colorWheelOn_Blue;
    public Sprite sprite_colorWheelOn_Green;

    public Button button_PowerState;
    public Button button_Yellow;
    public Button button_Orange;
    public Button button_Red;
    public Button button_Purple;
    public Button button_Blue;
    public Button button_Green;

    public bool powerState = false;
    public string currentColor = "white";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Turn the Color Wheel ON/OFF
    public void togglePower()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOff;     // Update the Color Wheel image
            powerState = false;
            // Turn the LED OFF
            currentColor = "white";
            // Set the LED to White
        }
        else
        {
            image_ColorWheel.sprite = sprite_colorWheelOn;      // Update the Color Wheel image
            powerState = true;
            // Turn the LED ON
        }
    }

    // Select YELLOW on the Color Wheel if the wheel is currently ON
    public void colorYellow()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Yellow;       // Update the Color Wheel image
            currentColor = "yellow";
            // Set the LED to YELLOW
        }
    }

    // Select ORANGE on the Color Wheel if the wheel is currently ON
    public void colorOrange()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Orange;       // Update the Color Wheel image
            currentColor = "orange";
            // Set the LED to ORANGE
        }
    }

    // Select RED on the Color Wheel if the wheel is currently ON
    public void colorRed()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Red;      // Update the Color Wheel image
            currentColor = "red";
            // Set the LED to RED
        }
    }

    // Select PURPLE on the Color Wheel if the wheel is currently ON
    public void colorPurple()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Purple;       // Update the Color Wheel image
            currentColor = "purple";
            // Set the LED to PURPLE
        }
    }

    // Select BLUE on the Color Wheel if the wheel is currently ON
    public void colorBlue()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Blue;     // Update the Color Wheel image
            currentColor = "blue";
            // Set the LED to BLUE
        }
    }

    // Select GREEN on the Color Wheel if the wheel is currently ON
    public void colorGreen()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Green;        // Update the Color Wheel image
            currentColor = "green";
            // Set the LED to GREEN
        }
    }
}
