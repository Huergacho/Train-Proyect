using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Wagon : MonoBehaviour
{
    private Wagon _neightBour;
    private bool _hasNeightBour;
    private int currentPassangers;
    [SerializeField] private Transform anchorPoint;
    public Transform AnchorPoint => anchorPoint;
    [SerializeField] private WagonStats _stats;
    private bool isFull()
    {
        return _stats.Capacity <= currentPassangers;
    }
    private void AddPassangers(int quantity)
    {
        if(!isFull())
        currentPassangers += quantity;
        else
        {
            Debug.Log("LLeno");
        }
    }
    private void AddNeightBour(Wagon neightbour)
    {
        if (!_hasNeightBour)
        {
            _neightBour = neightbour;
        }
    }
    public void DestroyVagon()
    {
        Destroy(gameObject);
    }

}
