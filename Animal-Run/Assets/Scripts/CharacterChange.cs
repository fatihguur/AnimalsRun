using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Cinemachine;
using UnityEngine;

public class CharacterChange : MonoBehaviour
{
    public GameObject objectToActive;

    
    public CinemachineVirtualCamera vcam;
    public ParticleSystem particle1;
    public ParticleSystem particle2;
    
    
    public Transform TigerFollow;
    public Transform DeerFollow;
    
    
    public GameObject Tiger;
    public GameObject Deer;
    
    public GameObject idle_tiger;
    public GameObject idle_deer;
    
    void Update()
    {
        
        TigerFollow = Tiger.transform;
        DeerFollow = Deer.transform;

    }

    void OnTriggerEnter(Collider other) 
    {
        Debug.Log("kssdf");

        
        if(other.transform.tag == "TriggerTiger") 
        {
            particle2.Play();
            objectToActive.SetActive(false);
            Destroy(idle_tiger);
            Tiger.GetComponent<Movement>().StartGame();
            Tiger.SetActive(true);
            Debug.Log("ksasddf");

            vcam.LookAt = TigerFollow;
            vcam.Follow = TigerFollow;
        }
        
        if(other.transform.tag == "TriggerDeer") 
        {
            Debug.Log("ksdf");
            particle1.Play();
            objectToActive.SetActive(false);
            Destroy(idle_deer);
            Deer.GetComponent<Movement>().StartGame();
            Deer.SetActive(true);

            vcam.LookAt = DeerFollow;
            vcam.Follow = DeerFollow;
        }
        
        
        
    }



}
