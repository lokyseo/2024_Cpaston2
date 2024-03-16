using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Sphere : MonoBehaviour
{
    public GameObject target_Sphere;
    int count_Spawn;
    float spawnTime = 0;
    float spawnInterval;
    public bool isSpawnStart;
    // Start is called before the first frame update
    void Start()
    {
        count_Spawn = 0;
        spawnInterval = 2.0f;
        isSpawnStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpawnStart)
        {
            spawnTime += Time.deltaTime;
            spawnInterval -= Time.deltaTime;
            if (spawnInterval < 0)
            {
                Instantiate(target_Sphere,
                    new Vector3(Random.Range(-15.0f, 15.0f), Random.Range(0, 10.0f), transform.position.z), Quaternion.identity);
                spawnInterval = 2.0f;
            }

            if (spawnTime > 30)
            {
                spawnTime = 0;
                this.GetComponent<Renderer>().material.color = Color.green;
                isSpawnStart = false;
            }
        }
        
    }
}
