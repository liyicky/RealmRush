using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> list = new List<Waypoint>();
    [SerializeField] [Range(0f, 5f)] float speed = 1f;

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
            Vector3 startPosition = transform.position;
            Vector3 endPosition = waypoint.transform.position;
            float travelPercentage = 0f;

            transform.LookAt(endPosition);

            while (travelPercentage < 1f)
            {
                travelPercentage += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercentage);
                yield return new WaitForEndOfFrame();
            }
        }
    }

}
