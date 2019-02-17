using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
        addPointstoDatabase();
    	Dictionary<Contestant,int> contestantPoints = rank.DecideRanks(contestants);
    	teamPlace.text = "Team place: " + place.ToString();
    	string rankingString = "";
    	Debug.Log("klsjdflsadjsdfds");
    	foreach(KeyValuePair<Contestant,int> entry in contestantPoints){

    		Debug.Log(entry.Key.GetName());
    		rankingString += entry.Value.ToString() + ". " + entry.Key.GetName() + "\n";
    		Debug.Log(entry.Value.ToString());
    	} 
    	contestantRanking.text = rankingString;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void addPointstoDatabase()
    {
        Contestant c = DatabaseManager.database.getMainPlayer();
        c.SetSinging(c.GetSinging() + 20);
        c.SetRapping(c.GetRapping() + 20);
        c.SetDancing(c.GetDancing() + 20);
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
