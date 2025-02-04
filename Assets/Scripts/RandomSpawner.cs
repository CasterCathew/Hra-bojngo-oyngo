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
            //zde se generuje náhodné èíslo mezi 0.5 a 3.0
            //což znamená že velikost té kostky bude zmenšeno o polovinu nebo zvìtšeno o trojnásobek a èísla mezi tím
            spawnedCube.transform.localScale = new Vector3(randomscale, randomscale, randomscale);
            //randomscale, randomscale, randomscale se rovná tomu že tím že jsou vlastnì všechny souøadnice stejné tak se zvìtšují èi zmenšují ve všech smìrech 
        }
    }
}
