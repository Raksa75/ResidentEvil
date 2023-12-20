using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Appel� lorsqu'on veut ouvrir la porte
    public void OpenDoor()
    {
        animator.SetTrigger("OpenTrigger");// "Open" est le nom du d�clencheur dans l'Animator
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
