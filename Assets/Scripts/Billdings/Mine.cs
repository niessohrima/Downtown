using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : Building
{
    // Start is called before the first frame update
    void Start()
    {
        GetValue(1000,30);
    }

    // Update is called once per frame
    void Update()
    {
        Work();
    }
}
