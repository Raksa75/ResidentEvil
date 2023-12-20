using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramassage_item : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cle"))
        {
            // La cl� a �t� ramass�e
            Destroy(other.gameObject); // D�truit la cl�
            // Autres actions � effectuer lors du ramassage de la cl� (par exemple, ouvrir la porte)
            OpenDoor();
        }

        else if (other.CompareTag("Porte"))
        {
            // Code pour ouvrir la porte
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
