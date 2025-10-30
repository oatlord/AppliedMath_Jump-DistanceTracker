using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DistanceDisplay : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI distanceText;
    private DistanceTracker distanceTracker;
    // Start is called before the first frame update
    void Start()
    {
        distanceTracker = player.GetComponent<DistanceTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceText.text = distanceTracker.GetDistance().ToString("F2");
    }
}
