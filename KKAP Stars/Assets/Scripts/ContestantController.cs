using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContestantController : MonoBehaviour
{
    public GameObject[] contestants;              
    public float spawnTime = 2f;           
    public Transform spawnPoint;        


    void Start()
    {
        int contestantIndex = Random.Range(0, contestants.Length);
        Instantiate(contestants[contestantIndex], spawnPoint.position, spawnPoint.rotation);
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        int contestantIndex = Random.Range(0, contestants.Length);
        Instantiate(contestants[contestantIndex], spawnPoint.position, spawnPoint.rotation);
    }
}
