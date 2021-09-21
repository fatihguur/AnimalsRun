using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleArray : MonoBehaviour
{

    public ObstacleMovement[] obstacleMov;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < obstacleMov.Length; i++)
        {
            obstacleMov = GetComponentsInChildren<ObstacleMovement>();
        }
    }

    public void DecreaseObstacleSpeed()
    {
        for (int i = 0; i < obstacleMov.Length; i++)
        {
            obstacleMov[i].speed += 0.1f;  
        }
    }
    
    public void IncreaseObstacleSpeed()
    {
        for (int i = 0; i < obstacleMov.Length; i++)
        {
            obstacleMov[i].speed -= 0.1f;  
        }
    }
    
    public void DecreaseObstacleRotateSpeed()
    {
        for (int i = 0; i < obstacleMov.Length; i++)
        {
            obstacleMov[i].rotateSpeed += 0.1f;  
        }
    }
    
    public void IncreaseObstacleRotateSpeed()
    {
        for (int i = 0; i < obstacleMov.Length; i++)
        {
            obstacleMov[i].rotateSpeed -= 0.1f;  
        }
    }
}
