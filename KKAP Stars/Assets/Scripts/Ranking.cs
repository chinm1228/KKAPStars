using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class Ranking 
{
    public Dictionary<Contestant, string> roles = RoleAssignment.GetRoles();

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public Dictionary<Contestant, int> GetResults()
    {
        Dictionary<Contestant, int> results = new Dictionary<Contestant, int>();
        foreach (KeyValuePair<Contestant, string> pair in roles)
        {
            double total = 0.0;
            int singing = pair.Key.GetSinging();
            int dancing = pair.Key.GetDancing();
            int rapping = pair.Key.GetRapping();
            int maxStat = 0;
            if (singing > rapping)
            {
                if (singing > dancing)
                {
                    if (pair.Value == "Singer")
                    {
                        total += singing;
                    }
                    else
                    {
                        if (pair.Value == "Dancer")
                        {
                            total += dancing * 0.75;
                        }
                        else
                        {
                            total += rapping * 0.75;
                        }
                    }
                }
            }
            else if (rapping > singing)
            {
                if (rapping > dancing)
                {
                    if (pair.Value == "Rapper")
                    {
                        total += rapping;
                    }
                    else if (pair.Value == "Singer")
                    {
                        total += singing * 0.75;
                    }
                    else
                    {
                        total += dancing * 0.75;
                    }
                }
            }
            else
            {
                maxStat = dancing;
                if (pair.Value == "Dancer")
                {
                    total += dancing;
                }
                else if (pair.Value == "Rapper")
                {
                    total += rapping;
                }
                else
                {
                    total += singing;
                }
            }
            results[pair.Key] = (int) total;
        }
        return results;
    }

    public Dictionary<Contestant, int> DecideRanks(Dictionary<Contestant, int> results)
    {
        Dictionary<Contestant, int> ranks = new Dictionary<Contestant, int>();
        
        var items = from pair in results
                    orderby pair.Value descending
                    select pair;


        int i = 0;
        foreach (KeyValuePair<Contestant, int> pair in items)
        {
            ranks[pair.Key] = i + 1;
            ++i;
        }
        return ranks;
    }

}
