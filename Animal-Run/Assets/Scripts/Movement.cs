using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    Rigidbody Animal_Rigidbody;
    public bool isPlaying;
    private Animator anim;
    
    public float playerRunSpeed = 1;
    public float playerSidewaySpeed = 1;
    public float xDeadLeft, xDeadRight;
    private DebugManager debugger;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        Animal_Rigidbody = GetComponent<Rigidbody>();
        debugger = GameObject.FindGameObjectWithTag("GameController").GetComponent<DebugManager>();

    }

    
    void Update()
    {
        GetInput();
        
    }

    private void FixedUpdate()
    {
        if (isPlaying)
        {
            Animal_Rigidbody.velocity = Vector3.forward * playerRunSpeed;
            
            if (isTouching)
            {
                touchPosX = Input.GetAxis("Mouse X") * playerSidewaySpeed * Time.fixedDeltaTime;
                Debug.Log(Input.GetAxis("Mouse X"));
                transform.position += new Vector3(touchPosX, 0, 0);
                    //float clamper = transform.position.z;
                
                float clamper = Mathf.Clamp(transform.position.x, xDeadLeft, xDeadRight);
                transform.position = new Vector3(clamper, transform.position.y, transform.position.z);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Jump")
        {
            anim.SetBool("isInAir", true);
            Debug.Log("Jumping");
        }
        
        if (other.transform.tag == "Finish")
        {
            debugger.FinishPassed();
        }
        
        if (other.transform.tag == "AttackTrigger")
        {
            anim.SetBool("CanAttack", true);
            Debug.Log("Attacking");
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Jump")
        {
            anim.SetBool("isInAir", false);
        }
        
        if (other.transform.tag == "Finish")
        {
            debugger.FinishPassed();
        }

        if(other.transform.tag == "AttackTrigger") 
        {
            anim.SetBool("CanAttack", false);
        }
    }
    
    public void StartGame()
    {
        Time.timeScale = 1f;
        isPlaying = true;
        
    }

    public void StartGameOnce()
    {
        anim.SetBool("isStarted",true);

    }
    
    bool isTouching;
    float touchPosX,rotDegree;
    Vector3 direction;
    
    //Testing Inputs
    void GetInput()
    {
        if (Input.GetMouseButton(0))
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }
    //Mobile Inputs
    void GetInputMobile()
    {
        if (Input.touchCount > 0)
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }
    
    
}
