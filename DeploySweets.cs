using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeploySweets : MonoBehaviour
{
    public GameObject[] sweetPrefabs;
    private float spawnRangeX = 460;
    private float spawnPosY = 440;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomSweet", 2, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomSweet()
    {
        int sweetIndex = Random.Range(0, sweetPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 440, spawnPosY);

        Instantiate(sweetPrefabs[sweetIndex], spawnPos, sweetPrefabs[sweetIndex].transform.rotation);
    }
}
