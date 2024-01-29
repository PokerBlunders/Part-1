using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsOnTrigger : MonoBehaviour
{
    public GameObject spawnObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            SpawnObject();
            Debug.Log("YUMMY CAKE!!!");
    }

    private void SpawnObject()
    {
        Vector3 spawnPosition = new Vector3(Random.Range((float)-3.7, -1), Random.Range((float)7.5, 9), 0);

        Instantiate(spawnObject, spawnPosition, Quaternion.identity);
    }
}

