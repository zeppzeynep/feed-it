using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 10.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    public GameObject[] animalPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        Instantiate(animalPrefabs[animalIndex], new Vector3(spawnPosX, 0, spawnPosZ), animalPrefabs[animalIndex].transform.rotation);
    }
}
