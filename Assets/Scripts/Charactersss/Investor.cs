using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investor : Character
{
    
    void Start()
    {
        SetupStartFunction("Investor",4,1,5);
    }
    
    void Update()
    {
        Work();
    }

    protected override void OnCollisionEnter(Collision other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (namePoint + currentPoint == other.gameObject.name)
        {
            _navMeshAgent.isStopped = true;
            isCollision = true;
            timeWork = timeValue;
            currentPoint += 1;
        }
    }
}
