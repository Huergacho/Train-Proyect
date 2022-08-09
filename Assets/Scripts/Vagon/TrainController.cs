using System;
using System.Collections.Generic;
using UnityEngine;
public class TrainController : MonoBehaviour
{
    [SerializeField] private List<Wagon> currentWagons;
    [SerializeField] private Wagon[] wagonPrefabs;
    [SerializeField] private Transform currentAnchor;
    [SerializeField] private Transform defaultAnchor;
    [SerializeField] private Transform wagonCarrier;
    public void Start()
    {
        currentAnchor = defaultAnchor;
    }
    public void AddVagon()
    {
        Wagon newVagon = MyRandom.GetRandom(wagonPrefabs);
        var vagonClone = Instantiate(newVagon,currentAnchor.position,currentAnchor.rotation,wagonCarrier);
        currentWagons.Add(vagonClone);
        var anchor = vagonClone.GetComponent<Wagon>().AnchorPoint;
        SetVagonAnchor(anchor);
    }
    public void RemoveVagon()
    {
        if(currentWagons.Count > 0)
        {
            currentWagons[currentWagons.Count - 1].DestroyVagon();
            currentWagons.RemoveAt(currentWagons.Count - 1);
            if (currentWagons.Count > 0)
            {
                SetVagonAnchor(currentWagons[currentWagons.Count - 1].AnchorPoint);

            }
            else
            {
                currentAnchor = defaultAnchor;
            }
        }
    }
    private Transform SetVagonAnchor(Transform newAnchorPoint)
    {
        return currentAnchor = newAnchorPoint;
    }
}
