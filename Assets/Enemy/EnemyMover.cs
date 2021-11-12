using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> list = new List<Waypoint>();

    // Start is called before the first frame update
    void Start()
    {
	PrintWaypoints();        
    }

    void PrintWaypoints()
    {
        foreach (Waypoint waypoint in list) 
        {
            Debug.Log(waypoint.name);
        }
    }

}
