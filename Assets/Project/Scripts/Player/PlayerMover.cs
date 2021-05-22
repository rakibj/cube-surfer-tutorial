using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    private void Update()
    {
        transform.Translate(0f, 0f, Time.deltaTime * moveSpeed);
    }
}
