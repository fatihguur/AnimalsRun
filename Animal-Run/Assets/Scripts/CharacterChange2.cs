using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Cinemachine;
using UnityEngine;

public class CharacterChange2 : MonoBehaviour
{
    public GameObject objectToActive;

    
    public CinemachineVirtualCamera vcam;
    public ParticleSystem particle1;
    public ParticleSystem particle2;
    
    public Transform RacoonFollow;
    public Transform DeerFollow;
    
    
    public GameObject Racoon;
    public GameObject Deer;

    public GameObject idle_racoon;
    public GameObject idle_deer;
    
    void Update()
    {
        RacoonFollow = Racoon.transform;
        DeerFollow = Deer.transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "TriggerRacoon")
        {
            particle1.Play();
            objectToActive.SetActive(false);
            Destroy(idle_racoon);
            Racoon.GetComponent<Movement>().StartGame();
            Racoon.SetActive(true);
            Racoon.GetComponent<Animator>().SetBool("isStarted",true);

            vcam.LookAt = RacoonFollow;
            vcam.Follow = RacoonFollow;
        }
        
        if(other.transform.tag == "TriggerDeer2") 
        {
            particle2.Play();
            objectToActive.SetActive(false);
            Destroy(idle_deer);
            Deer.GetComponent<Movement>().StartGame();
            Deer.SetActive(true);
            
            vcam.LookAt = DeerFollow;
            vcam.Follow = DeerFollow;
        }
        
        
        
    }



}