using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.AI;

public class Theft : Character
{
    public Transform target;
    public float speed = 4f;
    private Rigidbody rig;
    public bool theif;
    
    
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
    }

    private void TheftCharactere()
    {
        /*
        target=ReturnLocation().transform;
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed = Time.fixedDeltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
        Debug.Log("target1");
        */
    }

    
    
        
    
}