using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_item : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
