using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountControl : MonoBehaviour
{
	public static int counterValue;
	private string tmp;
	private string deviceID = "e00fce687482c84d64198d35";
	// Start is called before the first frame update
    async void Start() {
		await setCounter();
    }

    // Update is called once per frame
    void Update() {

    }
	
	public async void incrementCount() {      // Function for incrementing the counter; Public to allow it to be visible to the Unity project
		if (counterValue < 999) {
			await Helper.callFunction(deviceID, "display", "+");
			counterValue++;
		}
	}
	
	public async void decrementCount() {      // Function for decrementing the counter; Public to allow it to be visible to the Unity project
		if (counterValue > 0) {
			await Helper.callFunction(deviceID, "display", "-");
			counterValue--;
		}
	}

	private async Task setCounter() {
		tmp = await Helper.GetVariable(deviceID, "counter");
        counterValue = (int)Decimal.Parse(tmp);
	}
}
