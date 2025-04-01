using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDetector : MonoBehaviour
{
    // Start is called before the first frame update
 void OnParticleCollision(GameObject other)
    {
        Debug.Log("Rain particle hit the collector!");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
