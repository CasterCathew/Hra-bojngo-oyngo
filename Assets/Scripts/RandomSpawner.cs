using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject CubePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
            GameObject spawnedCube = Instantiate(CubePrefab, randomSpawnPosition, Quaternion.identity);
            float randomscale = Random.Range(0.5f, 3.0f); 
            //zde se generuje n�hodn� ��slo mezi 0.5 a 3.0
            //co� znamen� �e velikost t� kostky bude zmen�eno o polovinu nebo zv�t�eno o trojn�sobek a ��sla mezi t�m
            spawnedCube.transform.localScale = new Vector3(randomscale, randomscale, randomscale);
            //randomscale, randomscale, randomscale se rovn� tomu �e t�m �e jsou vlastn� v�echny sou�adnice stejn� tak se zv�t�uj� �i zmen�uj� ve v�ech sm�rech 
        }
    }
}
