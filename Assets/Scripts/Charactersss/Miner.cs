using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Miner : Character
{
    
    void Start()
    {
       SetupStartFunction("Mine", 5, 30,8);
    }
    
    void Update()
    {
        Work();
    }
}
