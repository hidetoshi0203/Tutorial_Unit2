using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;//生成範囲のx座標の限界
    private float spawnRangeZ = 20.0f;//生成範囲のz座標の場所
    private float startDelay = 2.0f;//動物が出始める時間
    private float spawnInterval = 1.5f;//生成間隔

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);//乱数
        float spawnX = Random.Range(-spawnRangeX, spawnRangeX);//x座標はランダム
        Vector3 spawnPos = new Vector3(spawnX, 0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay, spawnInterval);
    }

    void Update()
    {
        
    }
}
