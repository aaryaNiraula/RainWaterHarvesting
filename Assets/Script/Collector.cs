using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public float waterCollected = 0f; // Tracks collected water

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RainDrop")) // Ensure raindrops have this tag
        {
            waterCollected += 1f; // Increase water level
            Destroy(other.gameObject); // Remove the raindrop
        }
    }
}
