using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAtackers : MonoBehaviour
{
    public float spawnTime;
    public GameObject attackerPrefab;

    private float _currentSpawnTime;
    private void Start()
    {
        _currentSpawnTime = spawnTime;
    }
    private void Update()
    {
        if (spawnTime <= 0f)
        {
            SpawnAttackers();
            spawnTime = _currentSpawnTime;
        }
        spawnTime -= Time.deltaTime;
    }
    public void SpawnAttackers()
    {
        GameObject newAttacker = Instantiate(attackerPrefab, transform.position, Quaternion.identity);
        newAttacker.transform.parent = transform;
    }
}
