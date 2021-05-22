using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSensor : MonoBehaviour
{
    private PlayerStack _playerStack;

    private void Awake()
    {
        _playerStack = GetComponentInParent<PlayerStack>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Debug.Log("Found Collectible");
            var stackable = other.GetComponent<Stackable>();
            if (stackable)
            {
                Destroy(stackable.gameObject);
                _playerStack.AddToStack();
            }
        }
    }
}
