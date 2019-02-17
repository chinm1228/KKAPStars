using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class CalculatingPerfStats : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI teamPlace, contestantRanking;
    public Ranking rank;


    // Update is called once per frame

    void Awake(){
    	rank = new Ranking();
    	int place = calculatePlace();
    	Dictionary<Contestant,int> contestants = rank.GetResults();
    	Debug.Log(contestants.Count);
    	Dictionary<Contestant,int> contestantPoints = rank.DecideRanks(contestants);
    	teamPlace.text = "Team place: " + place.ToString();
    	string rankingString = "";
    	Debug.Log("klsjdflsadjsdfds");
    	foreach(KeyValuePair<Contestant,int> entry in contestantPoints){

    		Debug.Log(entry.Key.GetName());
    		rankingString += entry.Key.GetName() + " placed " + entry.Value.ToString() + "\n";
    		Debug.Log(entry.Value.ToString());
    	} 
    	contestantRanking.text = rankingString;
    }
    void Update()
    {
    	
        
    }

    int totalScore(){
    	int total_score = 0;
    	Dictionary<Contestant,int> contestantPoints = rank.GetResults();
    	foreach(KeyValuePair<Contestant,int> entry in contestantPoints){
    		total_score += entry.Value;
    	}
    	return total_score;
    }

    int calculatePlace(){
    	int total_score = totalScore();
    	if(total_score > 100){
    		return 1;
    	}
    	else if(total_score > 75){
    		return 2;
    	}
    	else if(total_score > 50){
    		return 3;
    	}
    	else{
    		return 4;
    	}

    }
}
