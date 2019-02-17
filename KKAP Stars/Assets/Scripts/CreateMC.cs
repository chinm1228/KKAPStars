using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateMC : MonoBehaviour
{
    public Contestant player;
    public Button submit;
    public InputField characterName;
    private ContestantDatabase cdb = new ContestantDatabase();
    private string[] companies = System.IO.File.ReadAllLines(@"Assets\Names\companies.txt");

    void Start()
    {
        submit.onClick.AddListener(createMainCharacter);
    }

    private string GenerateCompany(string[] companies)
    {
        System.Random r = new System.Random(DateTime.Now.Millisecond);
        int companyIndex = r.Next(0, companies.Length);
        return companies[companyIndex];
    }

    public void createMainCharacter()
    {
        string name = characterName.GetComponent<InputField>().text;
        string company = GenerateCompany(companies);
        player = new Contestant(name, company, 0, 0, 0, 0);
        cdb.SetContestants(49, player);
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }


}
