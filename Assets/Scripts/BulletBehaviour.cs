using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("kolize");

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
