using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private int spawnPosZ = 20;
    private int spawnRangeX = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            var index = Random.Range(0, animals.Length);
            var selectedAnimal = animals[index];
            Instantiate(selectedAnimal, new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ), selectedAnimal.transform.rotation);
        }
    }
}
