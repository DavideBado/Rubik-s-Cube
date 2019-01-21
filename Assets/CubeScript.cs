using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {
    public Material[] material;
    Renderer rend;
    GameObject Trigger;
    bool TriggerCheck, CheckLimitation;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
	}

    // Update is called once per frame
    void Update()
    {
        // Queste righe di codice permettono di capire quale fila è selezionata, ma cercando il GameObject Trigger in ogni update segnala una riga di errori,
        // ho provato a spostare il rend.sharedMaterial[0] in un TriggerExit, ma non lo legge....creando una funzione e richiamandola nello script dei trigger
        // le cose migliorano, ma evidenzia un solo cubo e non la fila, ho provato con i foreach, ma non sono riuscito a farli funzionare come volevo
        TriggerCheck = Trigger.GetComponent<Collider>().enabled;
        if (TriggerCheck == true)
        {
            rend.sharedMaterial = material[1];
        }
        else rend.sharedMaterial = material[0];
    }

    private void OnTriggerStay(Collider other)
    {
        this.transform.parent = other.transform;
        Trigger = other.gameObject;
        CheckLimitation = true;
    }    
}
