using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CTRL + M + O = Folds your code
// CTRL + M + P = Unfolds your code

public class Patrol : MonoBehaviour {

    public GameObject explosionPrefab;
    public float movementSpeed = 20f;
    public Transform[] patrolPoints;

    private int currentPoint = 0;
    private Rigidbody rigid;

    // Use this for initialization
    void Start() {

        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

   
    void Movement()
    {
        // Check if we have reached our waypoint
        if (transform. position == patrolPoints[currentPoint].position)
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

        Vector3 movePos = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, movementSpeed * Time.deltaTime);
        transform.position = movePos;
    }
}
