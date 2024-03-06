using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bollard : MonoBehaviour
{
    public Score scoreManager;
    //this method is called whenever a collision is detected
    private void OnCollisionEnter(Collision collision)
    {
        // printing if collision is detected on the console
        Debug.Log("Collision Detected");
        scoreManager.DecementPoint();
        Destroy(gameObject);

    }
}