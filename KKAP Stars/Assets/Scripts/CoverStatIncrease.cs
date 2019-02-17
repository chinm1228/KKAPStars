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
    	newSinging.GetComponent<TextMeshProUGUI>().SetText("Singing Ability: " + increaseStat(theGM.singingAbility).ToString());
    }

    public void dancingChosen(){
    	newDancing.SetActive(true);
    	danceButton.SetActive(false);
    	newDancing.GetComponent<TextMeshProUGUI>().SetText("Dancing Ability: " + increaseStat(theGM.dancingAbility).ToString());
    }

    public void rappingChosen(){
    	newRapping.SetActive(true);
    	rapButton.SetActive(false);
    	newRapping.GetComponent<TextMeshProUGUI>().SetText("Rapping Ability: " + increaseStat(theGM.rappingAbility).ToString());
    }


    public int increaseStat(int statNum){
    	if(firstPick){
    		firstPick = false;
    		secondPick = true;
    		int val = Mathf.RoundToInt(statNum + statAllocationPoints * .5f);
    		statAllocationPoints -= statAllocationPoints * .5f;  
    		Debug.Log(statAllocationPoints);
    		return val;
    	}
    	if(secondPick){
    		secondPick = false;
    		thirdPick = true;
    		int val = Mathf.RoundToInt(statNum + statAllocationPoints * .65f);
    		statAllocationPoints -= statAllocationPoints * .65f;
    		Debug.Log(statAllocationPoints);
    		return val;
    	}
    	else{
    		thirdPick = false;
    		int val = Mathf.RoundToInt(statNum + statAllocationPoints);
    		statAllocationPoints -= statAllocationPoints;
    		Debug.Log(statAllocationPoints);
    		return val;
    	}
    }
}
