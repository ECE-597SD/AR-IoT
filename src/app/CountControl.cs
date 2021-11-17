using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountControl : MonoBehaviour
{
	public int counterValue;
	
	// Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
		// Set the IRL Counter to counterValue
    }
	
	public void incrementCount() {      // Function for incrementing the counter; Public to allow it to be visible to the Unity project
		if (counterValue < 999) {
			counterValue++;
		}
	}
	
	public void decrementCount() {      // Function for decrementing the counter; Public to allow it to be visible to the Unity project
		if (counterValue > 0) {
			counterValue--;
		}
	}
}
