using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class EvalControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text question;
    public Button option1, option2, option3, option4;
    GameObject manager;
    
    void Start()
    {
        manager = GameObject.Find("databaseManager");
        option1.onClick.AddListener(TaskOnClick1);
        option2.onClick.AddListener(TaskOnClick2);
        option3.onClick.AddListener(TaskOnClick3);
        option4.onClick.AddListener(TaskOnClick4);
        DontDestroyOnLoad(manager);

    }

    void TaskOnClick1()
    {
        //player.sing stats increases
        Debug.Log("Before singing stat:" + DatabaseManager.database.getMainPlayer().GetSinging());
        int singingStat = DatabaseManager.database.getMainPlayer().GetSinging();
        DatabaseManager.database.getMainPlayer().SetSinging(singingStat + 7);

        Debug.Log("After singing stat:" + DatabaseManager.database.getMainPlayer().GetSinging());

        
        Debug.Log("player singing stats increase");

    }

    void TaskOnClick2()
    {
        //player.dance stats increases
        Debug.Log("Before dancing stat:" + DatabaseManager.database.getMainPlayer().GetDancing());
        int dancingStat = DatabaseManager.database.getMainPlayer().GetDancing();
        DatabaseManager.database.getMainPlayer().SetDancing(dancingStat + 7);

        Debug.Log("After dancing stat:" + DatabaseManager.database.getMainPlayer().GetDancing());
        Debug.Log("player dancing stats increase");
    }

    void TaskOnClick3()
    {
        //player.rapping stats increase
        Debug.Log("Before rapping stat:" + DatabaseManager.database.getMainPlayer().GetRapping());
        int rappingStat = DatabaseManager.database.getMainPlayer().GetRapping();
        DatabaseManager.database.getMainPlayer().SetRapping(rappingStat + 7);

        Debug.Log("After rapping stat:" + DatabaseManager.database.getMainPlayer().GetRapping());
        Debug.Log("player rapping stats increase");
    }

    void TaskOnClick4()
    {
        //all player stats increase + likability
        int singingStat = DatabaseManager.database.getMainPlayer().GetSinging();
        int dancingStat = DatabaseManager.database.getMainPlayer().GetDancing();
        int rappingStat = DatabaseManager.database.getMainPlayer().GetRapping();

        DatabaseManager.database.getMainPlayer().SetSinging(singingStat + 7);
        DatabaseManager.database.getMainPlayer().SetDancing(dancingStat + 7);
        DatabaseManager.database.getMainPlayer().SetRapping(rappingStat + 7);

        Debug.Log("player singing, dancing, stats, and likability increase");
    }


 
}
