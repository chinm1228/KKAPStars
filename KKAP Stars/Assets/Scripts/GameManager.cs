using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public bool currentRunning = false;

    public GameObject results;

    public GameObject hitsNum;

    public GameObject missNum;

    public bool gameEnd;

    public GameObject statsScreen;

    public GameObject singingText;

	public GameObject dancingText;

	public GameObject rappingText;

	public GameObject statIncreaseText;

	public int statIncreaseNumber;

	public int singingAbility;

	public int dancingAbility;

	public int rappingAbility;

	public GameObject startText;

	public GameObject continueText;


    // Start is called before the first frame update
    void Start()
    {
		singingAbility = DatabaseManager.database.getMainPlayer().GetSinging();
		dancingAbility = DatabaseManager.database.getMainPlayer().GetDancing(); 
		rappingAbility = DatabaseManager.database.getMainPlayer().GetRapping();   	
    	results.SetActive(false);
        gameInstance = this;
        notesHit = 0;
        notesMiss = 0;
        statsScreen.SetActive(false);
        continueText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying && !gameEnd){
        	if(Input.GetKeyDown(KeyCode.Space)){
        		startText.SetActive(false);
        		startPlaying = true;
        		currentRunning = true;
        		theBS.hasStarted = true;
        		theMusic.GetComponent<AudioSource>().Play();
        		startTime = Time.time;
        	}
        }

        elapsedTime = Time.time - startTime;
        
        if(startPlaying){
        	if(!theMusic.GetComponent<AudioSource>().isPlaying){
        		
        		startPlaying = false;
        		currentRunning = false;
        		theBS.hasStarted = false;
        		notesMiss -= notesHit;
        		results.SetActive(true);
        		hitsNum.GetComponent<TextMeshProUGUI>().SetText("Hit: " + notesHit.ToString());
        		missNum.GetComponent<TextMeshProUGUI>().SetText("Miss: " + notesMiss.ToString());
        		gameEnd = true;
        	}
        }

        if(gameEnd){
        	if(Input.GetKeyDown(KeyCode.Space)){
        		results.SetActive(false);
        		if(notesHit > notesMiss){
        			statIncreaseNumber = 50;
        		}
        		else{
        			Debug.Log("Game Over");
        		}
        		statsScreen.SetActive(true);
        		statIncreaseText.GetComponent<TextMeshProUGUI>().SetText("Stat Points Awarded: " + statIncreaseNumber.ToString());
        		singingText.GetComponent<TextMeshProUGUI>().SetText("Singing Ability: " + singingAbility.ToString());
        		dancingText.GetComponent<TextMeshProUGUI>().SetText("Dancing Ability: " + dancingAbility.ToString());
        		rappingText.GetComponent<TextMeshProUGUI>().SetText("Rapping Ability: " + rappingAbility.ToString());
        	}	
        }
        
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



}
