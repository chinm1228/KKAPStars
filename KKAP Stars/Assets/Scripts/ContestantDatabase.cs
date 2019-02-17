using System;
using System.Collections;
using System.Collections.Generic;

// The player is the last contestant in the array, i.e. contestants[49].
public class ContestantDatabase
{
    private Contestant[] contestants = new Contestant[50];
    private int[] remaining = new int[50];
    private string[] firstNames = System.IO.File.ReadAllLines(@"Assets\Names\firstNames.txt");
    private string[] lastNames = System.IO.File.ReadAllLines(@"Assets\Names\lastNames.txt");
    private string[] companies = System.IO.File.ReadAllLines(@"Assets\Names\companies.txt");

    public ContestantDatabase()
    {
        int statsCap = 31;

        for (int i = 0; i < 49; ++i)
        {
            string name = GenerateName(firstNames, lastNames, i);
            string company = GenerateCompany(companies, i);
            System.Random r = new System.Random(DateTime.Now.Millisecond + i);
            int singing = r.Next(0, statsCap);
            int rapping = r.Next(0, statsCap);
            int dancing = r.Next(0, statsCap);
            double starPower = r.NextDouble() * (statsCap - 0) + 0;
            contestants[i] = new Contestant(name, company, singing, rapping, dancing, starPower);
            remaining[i] = i;
        }
    }

    private string GenerateName(string[] firstNames, string[] lastNames, int seed) {
        if (seed > 10)
        {
            seed += 13;
        } else if (seed > 23) {
            seed /= 2;
        } else if (seed > 31)
        {
            seed *= 3;
        }
        System.Random r = new System.Random(seed);
        int firstNameIndex = r.Next(0, firstNames.Length);
        int lastNameIndex = r.Next(0, lastNames.Length);
        return lastNames[lastNameIndex] + " " + firstNames[firstNameIndex];
    }

    private string GenerateCompany(string[] companies, int seed)
    {
        System.Random r = new System.Random(seed);
        int companyIndex = r.Next(0, companies.Length);
        return companies[companyIndex];
    }

    public void SetContestants(int index, Contestant contestant)
    {
        contestants[index] = contestant;
        remaining[index] = index;
    }

    public Contestant[] GetRemainingContestants()
    {
        Contestant[] remainingContestants = new Contestant[remaining.Length];
        for (int i = 0; i < remaining.Length; ++i)
        {
            int index = remaining[i];
            remainingContestants[i] = contestants[index];
        }
        return remainingContestants;
    }

    public Contestant getMainPlayer()
    {
        return contestants[49];
    }

    public void SetRemaining(int[] newRemaining)
    {
        newRemaining.CopyTo(remaining, 0);
    }
}
