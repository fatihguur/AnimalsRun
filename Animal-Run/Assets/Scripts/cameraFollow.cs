using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraFollow : MonoBehaviour
{
    private CinemachineVirtualCamera vcam;
    
    
    void Start()
    {
        var vcam = GetComponent<CinemachineVirtualCamera>();
    }
}
