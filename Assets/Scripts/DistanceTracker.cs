using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
    public Transform startingCheckpoint;
    private Vector3 startingPos;
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = startingCheckpoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(startingPos, transform.position);
        Debug.Log(distance);
    }

    public float GetDistance()
    {
        return distance;
    }
}
