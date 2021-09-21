using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacoonCheck : MonoBehaviour
{
    private DebugManager debugger;
    // Start is called before the first frame update
    void Start()
    {
        debugger = GameObject.FindGameObjectWithTag("GameController").GetComponent<DebugManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            debugger.GameOver();
        }
    }

    
}