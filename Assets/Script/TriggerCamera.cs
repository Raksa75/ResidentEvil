using Cinemachine;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

[SelectionBase]
public class TriggerCamera : MonoBehaviour
{
    public CinemachineVirtualCamera VirtualCamera;
    public GameObject CameraPosition;

    private void OnTriggerEnter(Collider other)
  {
    // Vérifiez si l'objet qui entre en collision a le tag "Player"
        if(other.CompareTag("Player"))
    {
        // Déplacez la caméra uniquement si l'objet a le tag "Player"
        VirtualCamera.transform.position = CameraPosition.transform.position;
        VirtualCamera.transform.rotation = CameraPosition.transform.rotation;
    }
  }
}