using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
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

    private string deviceID = "e00fce687482c84d64198d35";


    // Start is called before the first frame update
    async void Start()
    {
        var tmp = await Helper.GetVariable(deviceID, "LED_state");
        if (tmp != "OFF") {
            powerState = true;
            currentColor = tmp == "ON" ? "WHITE" : tmp;
            image_ColorWheel.sprite = sprite_colorWheelOn;
        }
        else {
            powerState = false;
        }
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    private async Task setLED(string arg)
    {
        await Helper.callFunction(deviceID, "toggleLED", arg);
    }
    // Turn the Color Wheel ON/OFF
    public async void togglePower()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOff;
            powerState = false;
            currentColor = "WHITE";
            await setLED("OFF");

        }
        else
        {
            image_ColorWheel.sprite = sprite_colorWheelOn;
            powerState = true;
            await setLED("ON");
        }
    }

    // Select YELLOW on the Color Wheel if the wheel is currently ON
    public async void colorYellow()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Yellow;
            currentColor = "YELLOW";
            await setLED(currentColor);
        }
    }

    // Select ORANGE on the Color Wheel if the wheel is currently ON
    public async void colorOrange()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Orange;
            currentColor = "ORANGE";
            await setLED(currentColor);
        }
    }

    // Select RED on the Color Wheel if the wheel is currently ON
    public async void colorRed()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Red;
            currentColor = "RED";
            await setLED(currentColor);
        }
    }

    // Select PURPLE on the Color Wheel if the wheel is currently ON
    public async void colorPurple()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Purple;
            currentColor = "PURPLE";
            await setLED(currentColor);
        }
    }

    // Select BLUE on the Color Wheel if the wheel is currently ON
    public async void colorBlue()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Blue;
            currentColor = "BLUE";
            await setLED(currentColor);
        }
    }

    // Select GREEN on the Color Wheel if the wheel is currently ON
    public async void colorGreen()
    {
        if (powerState)
        {
            image_ColorWheel.sprite = sprite_colorWheelOn_Green;
            currentColor = "GREEN";
            await setLED(currentColor);
        }
    }
}
