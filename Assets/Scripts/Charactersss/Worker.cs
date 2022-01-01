using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.AI;



public class Worker : Character
{
    
    private void Start()
    {
       
        SetupStartFunction("House", 5, 20,6);
    }

    private void Update()
    { 
        Work();
    }
}