using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float spawnInterval = 1.5f;
    public float spawnRangeX = 5.0f;
    public float spawnIntervalDecreaseRate = 0.01f;

    private float timer;

    void Update()
    {

        spawnInterval = Mathf.Max(0.5f, spawnInterval - spawnIntervalDecreaseRate * Time.deltaTime);


        timer += Time.deltaTime;

        // Check if the timer has reached the spawn interval
        if (timer >= spawnInterval)
        {
            SpawnMeteor();
            timer = 0;
        }
    }

    void SpawnMeteor()
    {
        // Generate a random X position within the specified range
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, transform.position.z);

        // Instantiate (spawn) a new meteor at the spawn position
        Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
    }
}