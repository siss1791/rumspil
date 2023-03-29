using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnObstacle : MonoBehaviour
{
    public GameObject[] Obstacle;
    public float timeBetweenSpawn;
    private float spawnTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        int obstacleIndex = Random.Range(0, Obstacle.Length);

        Instantiate(Obstacle[obstacleIndex], transform.position, transform.rotation);

    }
}
