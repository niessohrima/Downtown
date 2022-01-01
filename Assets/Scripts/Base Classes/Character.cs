using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public abstract class Character : MonoBehaviour
{
    //values
    [SerializeField] private List <GameObject> locationPoint;
    protected int currentPoint;
    protected bool isCollision;
    protected float timeWork;
    protected GameObject location;
    protected string namePoint;
    private int health;
    private int money;
    protected NavMeshAgent _navMeshAgent;
    protected float timeValue;
    
    //functions
    private void WayPoint()
    {
        _navMeshAgent.destination = locationPoint[currentPoint].transform.position;
    }

    private void MakeMony()
    {
        money += 10;
        health = money;
        _navMeshAgent.isStopped = false;
        isCollision = false;
    }

    private void Timer()
    {
        timeWork -= 1 * Time.deltaTime;
    }

    protected virtual void Work()
    {
        if(isCollision == false)
        {
            WayPoint();
        }
        else
        {
            Timer();
		}
        if(timeWork < 0 && isCollision == true)
        {
            MakeMony();
		}
    }

    protected virtual void OnCollisionEnter(Collision other)
    {
        
        if (namePoint + currentPoint == other.gameObject.name)
        {
            _navMeshAgent.isStopped = true;
            isCollision = true;
            timeWork = timeValue;
            currentPoint += 1;
        }
    }
    
    protected virtual void FindGameobject(int numberOfBuilding , string name)
    {
        for(int i = 0; i < numberOfBuilding; i++)
        {
            locationPoint.Add(GameObject.Find(name + i));
        }
    }

    void Death()
    {
        if(health < 0)
        {
            gameObject.SetActive(false);
        }
    }
    
   protected virtual void SetupStartFunction( string namePoint, int numberOfBuilding, int healthMoney,int timeValue)
    {
        FindGameobject(numberOfBuilding,namePoint);
        _navMeshAgent = GetComponent<NavMeshAgent>();
        health=money = healthMoney;
        this.timeValue = timeValue;
        this.namePoint = namePoint;

    }
   
}
