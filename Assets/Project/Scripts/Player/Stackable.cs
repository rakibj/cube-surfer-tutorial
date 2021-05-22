using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stackable : MonoBehaviour
{
    private PlayerStack _playerStack;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Init(PlayerStack playerStack)
    {
        _playerStack = playerStack;
    }

    public void RemoveFromStack()
    {
        if (_playerStack == null) return;
        _playerStack.RemoveFromStack();
        _rigidbody.constraints = RigidbodyConstraints.None;
    }
}
