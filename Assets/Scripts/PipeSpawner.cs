using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 0.8f;
    public float timer = 0f;
    public float maxHeight = -0.2f;
    public float minHeight = 0.2f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    private void SpawnPipe()
    {
        float height = Random.Range(minHeight, maxHeight);
        Vector3 spawnPosition = new Vector3(3f, height, 0);

        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
