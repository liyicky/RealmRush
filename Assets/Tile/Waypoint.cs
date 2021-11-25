using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    [SerializeField] Tower towerPrefab;

    [SerializeField] bool isPlaceable;
    public bool IsPlaceble { get { return isPlaceable; } }

    
    void OnMouseDown()
    {
        if (isPlaceable)
        {
            bool isPlaced;
            isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);
            isPlaceable = isPlaced;
        }
    }
}
