using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    float spawnTimer;
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnTimer) {
            timer = 0.0f;
            spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-2f, 2f), transform.position.z), Quaternion.identity);
        }
    }
}
