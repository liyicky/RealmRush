using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> list = new List<Waypoint>();
    [SerializeField] float waittime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Coroutine");
	    StartCoroutine(PrintWaypoints());
        Debug.Log("Finished Coroutine");
    }

    IEnumerator PrintWaypoints()
    {
        foreach (Waypoint waypoint in list) 
        {
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waittime);
        }
    }

}
