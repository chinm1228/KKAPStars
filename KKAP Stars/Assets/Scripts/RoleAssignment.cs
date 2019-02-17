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

    private Dictionary<Contestant, string> rolesAssigned;
    
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
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		oneRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		oneRole.SetActive(true);
    		HighlightButtons(memberOne);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		oneRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		oneRole.SetActive(true);
    		HighlightButtons(memberOne);
    	}
    	
    }

    public void SetRoleTwo(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		twoRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		twoRole.SetActive(true);
    		HighlightButtons(memberTwo);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		twoRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		twoRole.SetActive(true);
    		HighlightButtons(memberTwo);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		twoRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		twoRole.SetActive(true);
    		HighlightButtons(memberTwo);
    	}
    	
    }

    public void SetRoleThree(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		threeRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		threeRole.SetActive(true);
    		HighlightButtons(memberThree);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		threeRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		threeRole.SetActive(true);
    		HighlightButtons(memberThree);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		threeRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		threeRole.SetActive(true);
    		HighlightButtons(memberThree);
    	}
    	
    }

    public void SetRoleFour(GameObject TM){  	
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		fourRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		fourRole.SetActive(true);
    		HighlightButtons(memberFour);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		fourRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		fourRole.SetActive(true);
    		HighlightButtons(memberFour);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		fourRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		fourRole.SetActive(true);
    		HighlightButtons(memberFour);
    	}
    	
    }

    public void SetRoleFive(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		fiveRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		fiveRole.SetActive(true);
    		HighlightButtons(memberFive);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		fiveRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		fiveRole.SetActive(true);
    		HighlightButtons(memberFive);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		fiveRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		fiveRole.SetActive(true);
    		HighlightButtons(memberFive);
    	}
    	
    }

    public void SetRoleSix(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		sixRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		sixRole.SetActive(true);
    		HighlightButtons(memberSix);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		sixRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		sixRole.SetActive(true);
    		HighlightButtons(memberSix);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer" && dancerCount < maxDancers){
    		sixRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		sixRole.SetActive(true);
    		HighlightButtons(memberSix);
    	}
    	
    }

    public void SetRoleSeven(GameObject TM){
    	if(TM.GetComponent<TextMeshProUGUI>().text == "Singer" && singerCount < maxSingers){
    		sevenRole.GetComponent<TextMeshProUGUI>().SetText("Singer");
    		singerCount += 1;
    		sevenRole.SetActive(true);
    		HighlightButtons(memberPlayer);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Rapper" && rapperCount < maxRappers){
    		sevenRole.GetComponent<TextMeshProUGUI>().SetText("Rapper");
    		rapperCount += 1;
    		sevenRole.SetActive(true);
    		HighlightButtons(memberPlayer);
    	}

       	if(TM.GetComponent<TextMeshProUGUI>().text == "Dancer"&& dancerCount < maxDancers){
    		sevenRole.GetComponent<TextMeshProUGUI>().SetText("Dancer");
    		dancerCount += 1;
    		sevenRole.SetActive(true);
    		HighlightButtons(memberPlayer);
    	}
    	
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
