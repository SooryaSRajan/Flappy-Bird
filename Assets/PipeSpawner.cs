using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    private float pipeSpawnTime = 2;
    public float minPipeTime = 1;
    public float maxPipeTime = 1;
    private float timer = 0;
    public GameObject pipe; 
    public float height;

    void Start()
    {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > pipeSpawnTime){
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10);
            timer = 0;
            pipeSpawnTime = Random.Range(minPipeTime, maxPipeTime);
        }
        timer += Time.deltaTime;
    }
}
