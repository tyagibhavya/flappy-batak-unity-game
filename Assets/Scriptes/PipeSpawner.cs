using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject pipe;

    private GameObject spawnedPipe;
    private float randomHeight;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    IEnumerator SpawnPipes()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            randomHeight = Random.Range(-1.5f, 1.5f);
            Vector2 spawnPosition = new Vector2(6, randomHeight);
            spawnedPipe = Instantiate(pipe, spawnPosition, Quaternion.identity);
        }
    }
}
