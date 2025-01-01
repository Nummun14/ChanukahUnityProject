using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {
    public GameObject pipe;
    public float pipeSpawnInterval = 2.5f;
    public float heightOffset = 5;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        spawnPipe();
    }

    // Update is called once per frame
    void Update() {
        if (timer < pipeSpawnInterval)
            timer += Time.deltaTime;
        else {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe() {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
