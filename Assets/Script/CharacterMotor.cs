using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotor : MonoBehaviour
{

    //Gestion des animations



    //Vitesse de déplacement
    public float walkSpeed;
    public float turnSpeed;


    //Setup des intups
    public string inputFront;
    public string inputBack;
    public string inputLeft;
    public string inputRight;

    CapsuleCollider playerCollider;


    // Start is called before the first frame update
    void Start()
    {
        playerCollider = gameObject.GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(inputFront)) //si on avance
        {
            transform.Translate(0, 0, walkSpeed * Time.deltaTime);
        }

        if (Input.GetKey(inputBack)) //si on recule
        {
            transform.Translate(0, 0, -(walkSpeed/2) * Time.deltaTime);
        }

        if (Input.GetKey(inputLeft)) //si on tourne a gauche
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(inputRight)) //si on tourne a droite
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }
    }
}
