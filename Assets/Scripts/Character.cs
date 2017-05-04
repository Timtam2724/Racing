using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    [Header("Character")]
    public float health = 100f;
    public float damage = 10f;
    public float moveSpeed = 21f;

    protected bool CheckDeath()
    {
        if (health <= 0)
        {
            return true;
        }
        return false;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
