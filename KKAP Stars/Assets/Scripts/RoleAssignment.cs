using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RoleAssignment : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject memberOne;

    public GameObject oneRole;

    public GameObject memberTwo;

	public GameObject twoRole;    
    
    public GameObject memberThree;

    public GameObject threeRole; 

    public GameObject memberFour;

    public GameObject fourRole; 

    public GameObject memberFive;

    public GameObject fiveRole; 

    public GameObject memberSix;

    public GameObject sixRole; 

    public GameObject memberPlayer;

    public GameObject sevenRole; 

    public int singerCount = 0;

    public int maxSingers = 2;

    public int rapperCount = 0;

    public int maxRappers = 2;

    public int dancerCount = 0;

    public int maxDancers = 3;

    public static Dictionary<Contestant, string> rolesAssigned;

    public Dictionary<Contestant, int> remainingContestants;

    private Dictionary<GameObject, Contestant> memberReferences;

    public static GameObject[] memberProfiles;
    
    public void HighlightButtons(GameObject member)
    {
    	
    	Button[] member_buttons = member.GetComponentsInChildren<Button>();

    	for(int i = 0; i < 3; i++){
    		member_buttons[i].gameObject.SetActive(false);
    		
    	}
    }

    public void SetRole(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		oneRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		oneRole.SetActive(true);
    		HighlightButtons(memberOne);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = oneRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		oneRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		oneRole.SetActive(true);
    		HighlightButtons(memberOne);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = oneRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		oneRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		oneRole.SetActive(true);
    		HighlightButtons(memberOne);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = oneRole.GetComponent<TextMeshProUGUI>().text;
    	}
    	
    }

    public void SetRoleTwo(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		twoRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		twoRole.SetActive(true);
    		HighlightButtons(memberTwo);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = twoRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		twoRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		twoRole.SetActive(true);
    		HighlightButtons(memberTwo);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = twoRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		twoRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		twoRole.SetActive(true);
    		HighlightButtons(memberTwo);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = twoRole.GetComponent<TextMeshProUGUI>().text;
    	}
    	
    }

    public void SetRoleThree(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		threeRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		threeRole.SetActive(true);
    		HighlightButtons(memberThree);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = threeRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		threeRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		threeRole.SetActive(true);
    		HighlightButtons(memberThree);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = threeRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		threeRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		threeRole.SetActive(true);
    		HighlightButtons(memberThree);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = threeRole.GetComponent<TextMeshProUGUI>().text;
    	}
    	
    }

    public void SetRoleFour(GameObject TM){  	
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		fourRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		fourRole.SetActive(true);
    		HighlightButtons(memberFour);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = fourRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		fourRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		fourRole.SetActive(true);
    		HighlightButtons(memberFour);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = fourRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		fourRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		fourRole.SetActive(true);
    		HighlightButtons(memberFour);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = fourRole.GetComponent<TextMeshProUGUI>().text;
    	}
    	
    }

    public void SetRoleFive(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		fiveRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		fiveRole.SetActive(true);
    		HighlightButtons(memberFive);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = fiveRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		fiveRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		fiveRole.SetActive(true);
    		HighlightButtons(memberFive);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = fiveRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		fiveRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		fiveRole.SetActive(true);
    		HighlightButtons(memberFive);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = fiveRole.GetComponent<TextMeshProUGUI>().text;

    	}
    	
    }

    public void SetRoleSix(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		sixRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		sixRole.SetActive(true);
    		HighlightButtons(memberSix);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = sixRole.GetComponent<TextMeshProUGUI>().text;

    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		sixRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		sixRole.SetActive(true);
    		HighlightButtons(memberSix);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = sixRole.GetComponent<TextMeshProUGUI>().text;
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		sixRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		sixRole.SetActive(true);
    		HighlightButtons(memberSix);
    		Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[c] = sixRole.GetComponent<TextMeshProUGUI>().text;
    	}
    	
    }

    public void SetRoleSeven(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		sevenRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		sevenRole.SetActive(true);
    		HighlightButtons(memberPlayer);
    		//Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[DatabaseManager.database.getMainPlayer()] = sevenRole.GetComponent<TextMeshProUGUI>().text;
    		DatabaseManager.database.getMainPlayer().SetSinging(DatabaseManager.database.getMainPlayer().GetSinging() + 30);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		sevenRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		sevenRole.SetActive(true);
    		HighlightButtons(memberPlayer);
    		//Contestant c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[DatabaseManager.database.getMainPlayer()] = sevenRole.GetComponent<TextMeshProUGUI>().text;
    		DatabaseManager.database.getMainPlayer().SetRapping(DatabaseManager.database.getMainPlayer().GetRapping() + 30);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		sevenRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		sevenRole.SetActive(true);
    		HighlightButtons(memberPlayer);
    		// c = memberReferences[TM.transform.parent.parent.gameObject];
    		rolesAssigned[DatabaseManager.database.getMainPlayer()] = sevenRole.GetComponent<TextMeshProUGUI>().text;
    		DatabaseManager.database.getMainPlayer().SetDancing(DatabaseManager.database.getMainPlayer().GetDancing() + 30);
    	}
    	
    }


    void Start()
    {

    	DatabaseManager.database.Increment();
    	rolesAssigned = new Dictionary<Contestant, string>();
    	memberProfiles = new GameObject[] {memberOne, memberTwo, memberThree, memberFour, memberFive, memberSix};
    	memberReferences = new Dictionary<GameObject, Contestant>();
    	remainingContestants = DatabaseManager.database.GetRemainingContestants();

    	
    	int i = 0;

    	foreach(KeyValuePair<Contestant, int> pair in remainingContestants) {
    		if(i == 6){
    			break;
    		}
    		memberReferences[memberProfiles[i]] = pair.Key;
    		GetFromDatabase(memberProfiles[i], pair);
    		i++;

    	}
    	GetFromDatabasePlayer(memberPlayer);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GetFromDatabasePlayer(GameObject member){
    	TextMeshProUGUI[] textToEdit = member.GetComponentsInChildren<TextMeshProUGUI>();
    	textToEdit[0].SetText("Singing:  " + DatabaseManager.database.getMainPlayer().GetSinging().ToString() + "| Dancing:  " + DatabaseManager.database.getMainPlayer().GetDancing().ToString() + "| Rapping:  " +  DatabaseManager.database.getMainPlayer().GetRapping().ToString());
    	textToEdit[4].SetText(DatabaseManager.database.getMainPlayer().GetName());
    }

    public void GetFromDatabase(GameObject member, KeyValuePair<Contestant, int> pair){
    	TextMeshProUGUI[] textToEdit = member.GetComponentsInChildren<TextMeshProUGUI>();
    	textToEdit[0].SetText("Singing:  " + pair.Key.GetSinging().ToString() + "| Dancing:  " + pair.Key.GetDancing().ToString() + "| Rapping:  " +  pair.Key.GetRapping().ToString());
    	textToEdit[4].SetText(pair.Key.GetName());
    }

    public static Dictionary<Contestant, string> GetRoles(){
    	return rolesAssigned;
    }
}
