using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovementArray : MonoBehaviour
{
    public Movement[] movement;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void isPlaying()
    {
        foreach (var character in movement)
        {
            character.isPlaying = false;
        }
    }

    public void MovementSpeedIncrease()
    {
        foreach (var character in movement)
        {
            character.playerRunSpeed += 1f;
        }
    }
    
    public void MovementSpeedDecrease()
    {
        foreach (var character in movement)
        {
            character.playerRunSpeed -= 1f;
        }
    }
    
    public void SidewaySpeedIncrease()
    {
        foreach (var character in movement)
        {
            character.playerSidewaySpeed += 1f;
        }
    }
    
    public void SidewaySpeedDecrease()
    {
        foreach (var character in movement)
        {
            character.playerSidewaySpeed -= 1f;
        }
    }
}
