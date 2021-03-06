using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public int round = 1;
    int zombiesInRound = 50;
    int zombiesSpawnedInRound = 0;
    float zombiesSpawnTimer = 0;
    public Transform[] zombiesSpawnPoints;
    public GameObject zombieEnemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (zombiesSpawnedInRound < zombiesInRound)
        {
            if (zombiesSpawnTimer > 5)

            {
                SpawnZombies();
                zombiesSpawnTimer = 0;
            }
            else
            {
                zombiesSpawnTimer+=Time.deltaTime;
            }
        }
    }

    void SpawnZombies()
    {
        Vector3 randomSpawnPoint = zombiesSpawnPoints[Random.Range(0, zombiesSpawnPoints.Length)].position;
        Instantiate(zombieEnemy, randomSpawnPoint, Quaternion.identity);
        zombiesSpawnedInRound++;
    }
}


