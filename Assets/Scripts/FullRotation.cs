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

        //*******************TEST MOUSE*******************************
        if (Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Forse funziona");
            }
        }
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed primary button.");

        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");

        //***************************************************
        GiveMeATurboSpin();

        // Help me Lord, I'm lost, I want my mommy point
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 140, 0));
        }
	}

    void GiveMeATurboSpin()
    {
        // Movimento con tastiera
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

        // Movimento con mouse
        if (Input.GetMouseButton(1))
        {
            if(Input.GetAxis("Mouse X")>0)
            {
                transform.RotateAround(Cube.transform.position, new Vector3(0, 1, 0), -1f);
            }
            if (Input.GetAxis("Mouse X") < 0)
            {
                transform.RotateAround(Cube.transform.position, new Vector3(0, 1, 0), 1f);
            }
            if (Input.GetAxis("Mouse Y") > 0)
            {
                transform.RotateAround(Cube.transform.position, new Vector3(1, 0, 0), 1f);
            }
            if (Input.GetAxis("Mouse Y") < 0)
            {
                transform.RotateAround(Cube.transform.position, new Vector3(1, 0, 0), -1f);
            }
        }
    }
}

