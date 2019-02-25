using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject blockPrefab;
    public float secondsBetweenSpawn = 0.5f;
    float nextSpawnTime;
    public float blockAnglemax;
    //public Vector3 blocksizeMinMax;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(25,1,Random.Range(-4, 4));
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector2.right * 90 * Time.deltaTime);
        if(Time.time> nextSpawnTime)
        {
            //float blocksize = Random.Range (blocksizeMinMax.x, blocksizeMinMax.y);
            float blockAngle = Random.Range(-blockAnglemax, blockAnglemax);
            nextSpawnTime = Time.time + secondsBetweenSpawn;
            Vector3 spawnPosition = new Vector3(20, 1, Random.Range(-3.5f, 3.5f));
            Instantiate(blockPrefab, spawnPosition, Quaternion.identity);
        }

        if(transform.position.x >= 50)
        {
            Destroy(gameObject);
        }
    }
}
