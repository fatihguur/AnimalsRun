using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraFollow : MonoBehaviour
{
    private CinemachineVirtualCamera vcam;
    
    // Start is called before the first frame update
    void Start()
    {
        var vcam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
