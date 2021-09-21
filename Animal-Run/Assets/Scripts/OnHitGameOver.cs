using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitGameOver : MonoBehaviour
{
    private DebugManager debugger;
    // Start is called before the first frame update
    void Start()
    {
        debugger = GameObject.FindGameObjectWithTag("GameController").GetComponent<DebugManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            debugger.GameOver();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            debugger.GameOver();

        }
    }
}
