using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public GameObject theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager gameInstance;

    public int notesHit;

    public int notesMiss;

    public float startTime;

    public float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        gameInstance = this;
        notesHit = 0;
        notesMiss = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying){
        	if(Input.anyKeyDown){
        		startPlaying = true;
        		theBS.hasStarted = true;
        		theMusic.GetComponent<AudioSource>().Play();
        		startTime = Time.time;
        	}
        }
        elapsedTime = Time.time - startTime;
    }

    public void NoteHit(GameObject note){
    	if(Mathf.Abs(elapsedTime - theMusic.GetComponent<AudioSource>().time) < .05){
    		Destroy(note);
    		note.SetActive(false);
    		notesHit += 1; 	
    	}
    }

    public void NoteMissed(GameObject note){
    	Destroy(note);
    	note.SetActive(false);
    	notesMiss += 1;
    }

    public void addToMiss(){
    	notesMiss += 1;
    }

}
