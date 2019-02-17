using System;

public class VoterDatabase
{
    private Voter[] voters = new Voter[100];

    public VoterDatabase()
    {
        System.Random r = new System.Random(DateTime.Now.Millisecond);

        for (int i = 0; i < 100; ++i)
        {
            int singingWeight = r.Next(26, 40);
            int rappingWeight = r.Next(26, 40);
            int dancingWeight = 100 - (singingWeight + rappingWeight);
            voters[i] = new Voter(singingWeight, rappingWeight, dancingWeight);
        }
    }
}
