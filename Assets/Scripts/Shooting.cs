using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField] public GameObject SpawnPoint;
    [SerializeField] public GameObject Bullet;
    public TimeManager timeManager;
    void Start()
    {
        timeManager = FindObjectOfType<TimeManager>();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(Bullet, SpawnPoint.transform.position, Quaternion.identity);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();

            rb.velocity = Camera.main.transform.forward * 150f;
            Destroy(bullet, 5);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            timeManager.Slowmotion();                        
        }
    }
   
}
