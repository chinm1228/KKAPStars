using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoverStatIncrease : MonoBehaviour
{

	public GameManager theGM;

	public GameObject newSinging;

	public GameObject newDancing;

	public GameObject newRapping;

	public GameObject singButton;

	public GameObject danceButton;

	public GameObject rapButton;

	public float statAllocationPoints;

	public bool firstPick = true;

	public bool secondPick = false;

	public bool thirdPick = false;


    // Start is called before the first frame update
    void Start()
    {
    	newSinging.SetActive(false);
    	newDancing.SetActive(false);
    	newRapping.SetActive(false);
        statAllocationPoints = theGM.statIncreaseNumber;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void singingChosen(){
    	newSinging.SetActive(true);
    	singButton.SetActive(false);
    	int val = increaseStat(theGM.singingAbility);
    	newSinging.GetComponent<TextMeshProUGUI>().SetText("Singing Ability: " + val.ToString());
    	DatabaseManager.database.getMainPlayer().SetSinging(val);
    }

    public void dancingChosen(){
    	newDancing.SetActive(true);
    	danceButton.SetActive(false);
    	int val = increaseStat(theGM.dancingAbility);
    	newDancing.GetComponent<TextMeshProUGUI>().SetText("Dancing Ability: " + val.ToString());
    	DatabaseManager.database.getMainPlayer().SetDancing(val);
    }

    public void rappingChosen(){
    	newRapping.SetActive(true);
    	rapButton.SetActive(false);
    	int val = increaseStat(theGM.rappingAbility);
    	newRapping.GetComponent<TextMeshProUGUI>().SetText("Rapping Ability: " + val.ToString());
    	DatabaseManager.database.getMainPlayer().SetRapping(val);
    }


    public int increaseStat(int statNum){
    	if(firstPick){
    		firstPick = false;
    		secondPick = true;
    		int val = Mathf.RoundToInt(statNum + statAllocationPoints * .5f);
    		statAllocationPoints -= statAllocationPoints * .5f;  
    		return val;
    	}
    	if(secondPick){
    		secondPick = false;
    		thirdPick = true;
    		int val = Mathf.RoundToInt(statNum + statAllocationPoints * .65f);
    		statAllocationPoints -= statAllocationPoints * .65f;
    		return val;
    	}
    	else{
    		thirdPick = false;
    		int val = Mathf.RoundToInt(statNum + statAllocationPoints);
    		statAllocationPoints -= statAllocationPoints;
    		return val;
    	}
    }
}
