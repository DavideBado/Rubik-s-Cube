using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputForRotation : MonoBehaviour {
    GameObject ColliderForRotation;
    int Selector, VertSelector;

    // Use this for initialization
    void Start ()
    {
        ColliderForRotation = null;
        Selector = -1;
        VertSelector = -1;
	}
	
	// Update is called once per frame
	void Update () {
        CheckTheFuckingInput();
	}

    // Function that....check the input (I hope)
    void CheckTheFuckingInput()
    {
        SelectYourFavoriteCollider();
        IPreferA90DegreeRotation();
    }

    void SelectYourFavoriteCollider()
    {
        // Now select vertical or horizontal collider
        if (Input.GetKeyDown(KeyCode.O))
        {
            Selector = 0;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            Selector = 1;
        }

        if (Selector == 0 && ColliderForRotation == null)
        {
            // Central collider is not for me
            if (Input.GetKeyDown(KeyCode.W))
            {
                ColliderForRotation = GameObject.Find("HorizUp");
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                ColliderForRotation = GameObject.Find("HorizDown");
            }
            else if (Input.GetKeyDown(KeyCode.C)) ColliderForRotation = GameObject.Find("HorizCentral");
        }

        if (Selector == 1 && ColliderForRotation == null)
        {
            // Vertical? Yeah but what vertical you want?
            if (Input.GetKeyDown(KeyCode.X))
            {
                VertSelector = 0;
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                VertSelector = 1;
            }

            if (VertSelector == 0)
            {
                if (Input.GetKeyDown(KeyCode.C))
                {
                    ColliderForRotation = GameObject.Find("VertXCentral");
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    ColliderForRotation = GameObject.Find("VertXLeft");
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    ColliderForRotation = GameObject.Find("VertXRight");
                }
            }
            else if (VertSelector == 1)
            {
                if (Input.GetKeyDown(KeyCode.C))
                {
                    ColliderForRotation = GameObject.Find("VertZCentral");
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    ColliderForRotation = GameObject.Find("VertZLeft");
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    ColliderForRotation = GameObject.Find("VertZRight");
                }
            }

        }
        if (Selector != -1)
        {
            if (Selector == 1 && VertSelector != -1)
            {
                ColliderForRotation.GetComponent<Collider>().enabled = true;
            }
            else if(Selector == 0)ColliderForRotation.GetComponent<Collider>().enabled = true;
        }
    }            

    void IPreferA90DegreeRotation()
    {
        // Oh yeah, rotate it
        if(Selector == 0)
        {
            // I chose the left side
            if (Input.GetKeyDown(KeyCode.A))
            {
                ColliderForRotation.transform.Rotate(new Vector3(0, 90f, 0));
                ColliderForRotation.GetComponent<Collider>().enabled = false;
                Selector = -1;
            }
            // I chose the alt-right side
            else if (Input.GetKeyDown(KeyCode.D))
            {
                ColliderForRotation.transform.Rotate(new Vector3(0, -90f, 0));
                ColliderForRotation.GetComponent<Collider>().enabled = false;
                Selector = -1;
            }
        }
        else if (Selector == 1 && VertSelector == 0)
        {           
            // Mi sono rotto il cazzo di commentare
            if (Input.GetKeyDown(KeyCode.W))
            {
                ColliderForRotation.transform.Rotate(new Vector3(0, 0, 90f));
                //ColliderForRotation.GetComponent<Collider>().enabled = false;
                Selector = -1;
                VertSelector = -1;
            }
           
            else if (Input.GetKeyDown(KeyCode.S))
            {
                ColliderForRotation.transform.Rotate(new Vector3(0, 0, -90f));
                //ColliderForRotation.GetComponent<Collider>().enabled = false;
                Selector = -1;
                VertSelector = -1;
            }
        }
        else if (Selector == 1 && VertSelector == 1)
        {
            
            if (Input.GetKeyDown(KeyCode.W))
            {
                ColliderForRotation.transform.Rotate(new Vector3(90f, 0, 0));
                //ColliderForRotation.GetComponent<Collider>().enabled = false;
                Selector = -1;
                VertSelector = -1;
            }
           
            else if (Input.GetKeyDown(KeyCode.S))
            {
                ColliderForRotation.transform.Rotate(new Vector3(-90f, 0, 0));
                //ColliderForRotation.GetComponent<Collider>().enabled = false;
                Selector = -1;
                VertSelector = -1;
            }
        }
        if(Selector == -1 || Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.V))
        {
            ColliderForRotation.GetComponent<Collider>().enabled = false;
            ColliderForRotation = null;
        }
    }
}
