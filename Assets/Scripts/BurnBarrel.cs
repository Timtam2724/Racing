using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnBarrel : MonoBehaviour
{
    public GameObject Bullet;


    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}