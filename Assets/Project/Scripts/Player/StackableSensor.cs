using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackableSensor : MonoBehaviour
{
    private Stackable _stackable;

    private void Awake()
    {
        _stackable = GetComponentInParent<Stackable>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("Found Obstacle");
            _stackable.RemoveFromStack();
        }
    }
}
