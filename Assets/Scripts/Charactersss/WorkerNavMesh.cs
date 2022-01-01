using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using  UnityEngine.AI;
using UnityEngine;
using UnityEngine.UI;


public class WorkerNavMesh : Character
{
  
  
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        collisionForWork = false;
        listLength = movePositionTransform.Count;
        tagName = "work";

    }

    private void Update()
    {
       
            WayPointt();
            Timer();
        
      //  transform.LookAt(transform.position + cam.forward);
                
    }

   
}
