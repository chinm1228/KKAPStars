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
    
    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        option1.onClick.AddListener(TaskOnClick1);
        option2.onClick.AddListener(TaskOnClick2);
        option3.onClick.AddListener(TaskOnClick3);
        option4.onClick.AddListener(TaskOnClick4);

    }

    void TaskOnClick1()
    {
        //player.sing stats increases

        Debug.Log("player singing stats increase");

    }

    void TaskOnClick2()
    {
        //player.dance stats increases
        Debug.Log("player dancing stats increase");
    }

    void TaskOnClick3()
    {
        //player.rapping stats increase
        Debug.Log("player rapping stats increase");
    }

    void TaskOnClick4()
    {
        //all player stats increase + likability
        Debug.Log("player singing, dancing, stats, and likability increase");
    }


 
}
