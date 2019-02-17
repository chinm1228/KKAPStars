using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SetFinal9 : MonoBehaviour
{
    private Contestant[] finalists = new Contestant[9];
    private ContestantDatabase cdb = new ContestantDatabase();
    private VoterDatabase vdb = new VoterDatabase();
    // Start is called before the first frame update
    void Start()
    {
        DetermineFinalists();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DetermineFinalists()
    {
        Contestant[] remaining = cdb.GetRemainingContestants();
        Voter[] voters = vdb.GetVoters();
        Dictionary<Contestant, int> currentResults = new Dictionary<Contestant, int>();

        for (int c = 0; c < remaining.Length; ++c)
        {
            int total = 0;
            foreach (Voter v in voters)
            {
                total += remaining[c].GetSinging() * v.GetSingingWeight()
                    + remaining[c].GetRapping() * v.GetRappingWeight()
                    + remaining[c].GetDancing() * v.GetDancingWeight();
            }
            currentResults.Add(remaining[c], total);
        }

        var items = from pair in currentResults
                    orderby pair.Value descending
                    select pair;

        
        int i = 0;
        foreach (KeyValuePair<Contestant, int> pair in items)
        {
            if (i < 9)
            {
                finalists[i] = pair.Key;
            }
            else
            {
                return;
            }
            ++i;
        }
    }

    // Already sorted.
    public Contestant[] GetFinalists()
    {
        return finalists;
    }
}
