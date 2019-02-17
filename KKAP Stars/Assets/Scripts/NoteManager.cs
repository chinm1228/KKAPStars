using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] notes;

    public float spawnTime;

    public Transform[] spawnPoints;

    public GameObject arrowContainer;

    public GameManager theGM;

    void Start()
    {
    	spawnTime = 158/180f;
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
    	
    }

    void Spawn(){
    	if(theGM.startPlaying){
    		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
	        GameObject noteSpawned = Instantiate(notes[spawnPointIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	       	noteSpawned.transform.parent = arrowContainer.transform;	
    	}
    }
}
