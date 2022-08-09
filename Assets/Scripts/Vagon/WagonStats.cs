using System;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Vagon Stats", menuName = "Vagon", order = 0)]
public class WagonStats : ScriptableObject
{
    [SerializeField] private int _capacity;
    public int Capacity => _capacity;
}
