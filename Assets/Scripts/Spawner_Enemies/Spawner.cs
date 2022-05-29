using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] astroidSpawnPoints;
    public GameObject astroidPrefab;

    public Transform[] enemySpawnPoints;
    public GameObject enemyPrefab;

    private bool canSpawnAstroid = true;

    private bool canSpawnEnemy = true;

    [SerializeField] float spawnCooldownAstroid = 1f;

    [SerializeField] float spawnCooldownEnemy = 1f;


    void Update()
    {
        if (canSpawnAstroid)
        {
            StartCoroutine("SpawnAstroids", spawnCooldownAstroid);
            canSpawnAstroid = false;
        }

        if (canSpawnEnemy)
        {
            StartCoroutine("SpawnEnemy", spawnCooldownEnemy);
            canSpawnEnemy = false;
        }

    }

    IEnumerator SpawnAstroids(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        int randSpawnPoint = Random.Range(0, astroidSpawnPoints.Length);

        Instantiate(astroidPrefab, astroidSpawnPoints[randSpawnPoint].position, transform.rotation);

        canSpawnAstroid = true;
    }

    IEnumerator SpawnEnemy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        int randSpawnPoint = Random.Range(0, enemySpawnPoints.Length);

        Instantiate(enemyPrefab, enemySpawnPoints[randSpawnPoint].position, transform.rotation);

        canSpawnEnemy = true;
    }
}
