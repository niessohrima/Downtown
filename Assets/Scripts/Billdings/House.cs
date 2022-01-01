using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : Building
{
    
    void Start()
    {
         GetValue(500,25);
    }

    
    void Update()
    {
        Work();
    }
}
