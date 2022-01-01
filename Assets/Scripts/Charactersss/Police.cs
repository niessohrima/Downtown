using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;


public class Police : Character
{
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        collisionForWork = false;
        listLength = movePositionTransform.Count;
    }

    // Update is called once per frame
    void Update()
    {
        WayPointt();
        Timer(); 
    }
}
