using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramassage_item : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cle"))
        {
            // La clé a été ramassée
            Destroy(other.gameObject); // Détruit la clé
            // Autres actions à effectuer lors du ramassage de la clé (par exemple, ouvrir la porte)
            OpenDoor();
        }

        else if (other.CompareTag("Cle2"))
        {
            // La clé a été ramassée
            Destroy(other.gameObject); // Détruit la clé
            // Autres actions à effectuer lors du ramassage de la clé (par exemple, ouvrir la porte)
            OpenDoor2();
        }
        
    }

    void OpenDoor()
    {
        GameObject[] doors = GameObject.FindGameObjectsWithTag("Porte");
        foreach (GameObject door in doors)
        {
            door.GetComponent<DoorController>().OpenDoor();
        }
    }

    void OpenDoor2()
    {
        GameObject[] doors = GameObject.FindGameObjectsWithTag("Porte2");
        foreach (GameObject door in doors)
        {
            door.GetComponent<DoorController>().OpenDoor();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
