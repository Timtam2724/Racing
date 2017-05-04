using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof (NavMeshAgent))]
public class AIRacer : Character {

    [Header("AIRacer")]

    public float movementSpeed = 20f;
    public Transform target;
    public Transform[] patrolPoints;

    private int currentPoint = 0;

    protected NavMeshAgent agent;

    protected virtual void Awake()
    {
        agent = GetComponent< NavMeshAgent > ();
    }

    protected virtual void FixedUpdate()
    {
        Vector3 movePos = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, movementSpeed * Time.deltaTime);
        transform.position = movePos;
    }
    void Movement()
    {
        // Check if we have reached our waypoint
        if (transform.position == patrolPoints[currentPoint].position)
        {
            // Increment currentPoint by 1
            currentPoint++;
            //transform.LookAt(patrolPoints[currentPoint]);
        }

        // Check if currentPoint is outside range of array
        if (currentPoint >= patrolPoints.Length)
        {
            // Reset currentPoint to 0
            currentPoint = 0;
        }       
    }
}
