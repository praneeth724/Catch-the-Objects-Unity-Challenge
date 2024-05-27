using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public float spawninterval = 1f;
    public GameObject objectprefab;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawninterval);
        
    }

    void SpawnObject()
    {
        float spawnX = Random.Range(-20f, 20f);
        float spawnZ = Random.Range(-20f, 20f);
        Vector3 spawnPos = new Vector3(spawnX, transform.position.y, spawnZ);
        Instantiate(objectprefab, spawnPos, Quaternion.identity);
    }

 
}
