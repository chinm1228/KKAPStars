using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class SetFinal9 : MonoBehaviour
{
    private Queue<Contestant> finalists = new Queue<Contestant>();
    public TextMeshProUGUI resultsText;
    public GameController controller;

    private ContestantDatabase cdb = new ContestantDatabase();
    GameObject manager;
    private VoterDatabase vdb = new VoterDatabase();
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("databaseManager");
        DontDestroyOnLoad(manager);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //&& !controller.CheckIfPaused())
        {
            DisplayNextSentence();
        }
    }

    private void DetermineFinalists()
    {
        //Contestant[] remaining = DatabaseManager.database.GetRemainingContestants();
        Dictionary<Contestant, int> remaining = cdb.GetRemainingContestants();
        Voter[] voters = vdb.GetVoters();
        Dictionary<Contestant, int> currentResults = new Dictionary<Contestant, int>();

        foreach (KeyValuePair<Contestant, int> pair in remaining)
        {
            int total = 0;
            foreach (Voter v in voters)
            {
                total += pair.Key.GetSinging() * v.GetSingingWeight()
                    + pair.Key.GetRapping() * v.GetRappingWeight()
                    + pair.Key.GetDancing() * v.GetDancingWeight();
            }
            currentResults.Add(pair.Key, total);
        }

        var items = from pair in currentResults
                    orderby pair.Value descending
                    select pair;


        int i = 0;
        foreach (KeyValuePair<Contestant, int> pair in items)
        {
            if (i < 9)
            {
                finalists.Enqueue(pair.Key);
  
            }
            else
            {
                return;
            }
            ++i;
        }
    }

    public void StartDialogue()
    {
        DetermineFinalists();
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (finalists.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = finalists.Dequeue().GetName();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        resultsText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            resultsText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        SceneManager.LoadScene(0);
    }
}