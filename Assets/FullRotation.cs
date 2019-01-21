using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullRotation : MonoBehaviour {
    float Input_X, Input_Y;   
  
    // Update is called once per frame
    void Update () {
        GiveMeATurboSpin();

        // Help me Lord, I'm lost, I want my mommy point
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.transform.rotation = Quaternion.identity;
        }
	}

    void GiveMeATurboSpin()
    {
        Input_X = Input.GetAxis("Horizontal");
        Input_X *= Time.deltaTime;
        Input_Y = Input.GetAxis("Vertical");
        Input_Y *= Time.deltaTime;

        if(Input_X != 0)
        {
            this.transform.Rotate(new Vector3(0, 1f));
        }
        if (Input_Y != 0)
        {
            this.transform.Rotate(new Vector3(1f, 0));
        }
    }
}

