// No setter functions because the weights never change over time.

public class Voter
{
    private int singingWeight;
    private int rappingWeight;
    private int dancingWeight;

    public Voter(int newSingingWeight, int newRappingWeight, int newDancingWeight)
    {
        singingWeight = newSingingWeight;
        rappingWeight = newRappingWeight;
        dancingWeight = newDancingWeight;
    }

    public int GetSingingWeight()
    {
        return singingWeight;
    }

    public int GetRappingWeight()
    {
        return rappingWeight;
    }

    public int GetDancingWeight()
    {
        return dancingWeight;
    }
}