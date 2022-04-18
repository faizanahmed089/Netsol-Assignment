using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float startTime = 1.0f;
    private Vector3 spawnPos = new Vector3(0, 500, -400);

    // Make a bool in Enemy and set true when Enemy itself destroy. Here instantiate enemy in start and make a condition when bool true*
    // *Instantiate after some fixed delay
    void Start()
    {
        Spawn();
    }

    void Update()
    {
        SpawnwithDelay();
    }

    void SpawnwithDelay()
    {
        if (Enemy.Instance.isDestroyed == true)
        {
            Invoke("Spawn", 2);
            Enemy.Instance.isDestroyed = false;
        }
    }

    void Spawn()
    {
        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
    }
}





