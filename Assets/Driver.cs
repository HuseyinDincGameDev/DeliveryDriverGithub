using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Driver : MonoBehaviour
{

    float steerSpeed = 1f;
    float moveSpeed = 0.01f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, moveSpeed, 0);
        transform.Rotate(0, 0, steerSpeed);
    }
}
