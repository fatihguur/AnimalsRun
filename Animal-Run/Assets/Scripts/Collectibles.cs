using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectibles : MonoBehaviour
{
    private DebugManager debugger;

    private void Start()
    {
        debugger = GameObject.FindGameObjectWithTag("GameController").GetComponent<DebugManager>();
    }


    void OnTriggerEnter (Collider other)
    {
        if (other.transform.CompareTag("Collectible"))
        {
            debugger.coin++;
            debugger.textCoins.text = debugger.coin.ToString();
            Destroy(other.gameObject);
        }
    }
    
}
