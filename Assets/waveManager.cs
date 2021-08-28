using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random=UnityEngine.Random;
[Serializable]
public class Wave
{
    public string waveName;
    public int numOfEnemies;
    public GameObject[] typeOfEnemies;
    public float spawnIntreval;
}


public class waveManager : MonoBehaviour
{
    [SerializeField] Wave[] waves;
    public Transform[] spawnPoints;
    private Wave currentWave;
    private int currentWaveNumber;
    private bool canSpawn = true;
    private float nextSpawnTime;
    public Text waveName;
    public GameObject waveNameparent;
    public GameObject waveComplete;
    private bool canContinue = false;
    void Start()
    {
        
    }

    void Update()
    {
        currentWave = waves[currentWaveNumber];
        SpawnWave();
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("enemy");
        if(totalEnemies.Length == 0)
        {

            if(currentWaveNumber+1 != waves.Length)
            {

                    if(canContinue)
                    {
                         waveName.text = "Wave: " + waves[currentWaveNumber + 1].waveName;
                         //waveComplete.SetActive(true);
                         //waveComplete.SetActive(true);
                         waveNameparent.SetActive(true);

                         canContinue =false;
                         Invoke("SpawnNextWave", 8);
                    }
            }
            else
            {
                Debug.Log("game finish");
            }

        }
    }


    void SpawnNextWave()
    {
            currentWaveNumber++;
            canSpawn = true;
    }

    void SpawnWave()
    {
        if(canSpawn && nextSpawnTime < Time.time)
        {
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
            currentWave.numOfEnemies--;
            nextSpawnTime = Time.time + currentWave.spawnIntreval;
            if(currentWave.numOfEnemies == 0)
            {
                canSpawn = false;
                canContinue = true;
            }
        }


    }
}
