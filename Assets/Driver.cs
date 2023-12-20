using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Driver : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, 0.01f, 0);
        transform.Rotate(0, 0, 0.1f);
    }
}
