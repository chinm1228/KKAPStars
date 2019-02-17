using System;

public class VoterDatabase
{
    private Voter[] voters = new Voter[100];

    public VoterDatabase()
    {
        System.Random r = new System.Random(DateTime.Now.Millisecond);

        for (int i = 0; i < 100; ++i)
        {
            int singingWeight = r.Next(0, 6);
            int rappingWeight = r.Next(0, 6);
            int dancingWeight = r.Next(0, 6);
            voters[i] = new Voter(singingWeight, rappingWeight, dancingWeight);
        }
    }

    public Voter[] GetVoters()
    {
        return voters;
    }
}
