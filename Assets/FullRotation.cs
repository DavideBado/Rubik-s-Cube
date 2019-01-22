using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullRotation : MonoBehaviour {
    float Input_X, Input_Y;
    GameObject Cube;
    private void Awake()
    {
        Cube = gameObject;
    }

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
        if(Input.GetKey(KeyCode.RightArrow))
        {           
            transform.RotateAround(Cube.transform.position, new Vector3(0, 1, 0), -1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(Cube.transform.position, new Vector3(0, 1, 0), 1f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAround(Cube.transform.position, new Vector3(1, 0, 0), 1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.RotateAround(Cube.transform.position, new Vector3(1, 0, 0), -1f);
        }
    }
}

