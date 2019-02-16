using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContestantDatabase
{
    private Contestant[] contestants = new Contestant[50];
    private string[] firstNames = System.IO.File.ReadAllLines(@"Assets\Names\firstNames.txt");
    private string[] lastNames = System.IO.File.ReadAllLines(@"Assets\Names\lastNames.txt");
    private string[] companies = System.IO.File.ReadAllLines(@"Assets\Names\companies.txt");

    public ContestantDatabase()
    {
        Random rnd = new Random();
        int statsCap = 40;

        for (int i = 0; i < 49; ++i)
        {
            string name = generateName(firstNames, lastNames);
            string company = generateCompany(companies);
            int singing = rnd.NextInt(0, statsCap);
            int rapping = rnd.NextInt(0, statsCap);
            int dancing = rnd.NextInt(0, statsCap);
            int likability = rnd.NextInt(0, statsCap);
            double starPower = rnd.NextDouble() * (statsCap - 0) + 0;
            contestants[i] = new Contestant(name, company, singing, rapping, dancing,
                likability, starPower);
        }
    }

    private string generateName(string[] firstNames, string[] lastNames) {
        Random rnd = new Random();
        
        int firstNameIndex = new rnd.NextInt(0, firstNames.Length);
        int lastNameIndex = new rnd.NextInt(0, lastNames.Length);
        return lastNames[lastNameIndex] + " " + firstNames[firstNameIndex];
    }

    private string generateCompany(string[] companies)
    {
        Random rnd = new Random();
        int companyIndex = new rnd.NextInt(0, companies.Length);
        return companies[companyIndex];
    }
}
