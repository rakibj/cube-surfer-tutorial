using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStack : MonoBehaviour
{
    [SerializeField] private Stackable stackablePrefab;
    [SerializeField] private Transform playerModel;
    [SerializeField] private float stackableHeight = 1f;
    [SerializeField] private int startingStack = 2;
    private float _currentY = 0;
    private List<Stackable> _stackables = new List<Stackable>();

    private void Start()
    {
        for (int i = 0; i < startingStack; i++)
            AddToStack();
    }

    [ContextMenu("AddToStack")]
    public void AddToStack()
    {
        playerModel.localPosition = new Vector3(0, _currentY + stackableHeight, 0);
        var stackable = Instantiate(stackablePrefab, transform.position, Quaternion.identity, transform);
        _stackables.Add(stackable);
        stackable.Init(this);
        stackable.transform.localPosition = new Vector3(0, _currentY, 0);
        _currentY += stackableHeight;
    }
    
    [ContextMenu("RemoveFromStack")]
    public void RemoveFromStack()
    {
        if (_stackables == null || _stackables.Count == 0) return;
        var stackable = _stackables[0];
        _stackables.RemoveAt(0);
        stackable.transform.parent = null;
        _currentY -= stackableHeight;
        //Destroy(stackable.gameObject); //Don't keep it in game;
    }

}
