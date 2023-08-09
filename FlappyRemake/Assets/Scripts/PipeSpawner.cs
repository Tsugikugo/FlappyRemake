using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 2.5f;
    public float heightRange = 3f;
    public GameObject pipe;

    private float timer = 0;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 SpawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject Pipe = Instantiate(pipe, SpawnPos, Quaternion.identity);

        Destroy(Pipe, 13.24f/1.5f);
    }
}
