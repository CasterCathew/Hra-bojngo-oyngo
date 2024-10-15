using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField] public GameObject SpawnPoint;
    [SerializeField] public GameObject Bullet;
    void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            GameObject bullet = Instantiate(Bullet, SpawnPoint.transform.position, Quaternion.identity); 
            Rigidbody rb = bullet.GetComponent<Rigidbody>();

            rb.AddForce(Camera.main.transform.forward * 2000);
            Destroy(bullet, 5);
        }
    }
   
}
