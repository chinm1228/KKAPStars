public class Contestant
{
    private string name;
    private string company;
    private int singing;
    private int rapping;
    private int dancing;
    private int likability;
    private double starPower;

    public Contestant(string newName, string newCompany, double newSinging, double newRapping, double newDancing,
        double newLikability, double newStarPower)
    {
        name = newName;
        company = newCompany;
        singing = newSinging;
        rapping = newRapping;
        dancing = newDancing;
        likability = newLikability;
        starPower = newStarPower;
    }

    public void setName(string newName)
    {
        name = newName;
    }

    public string getName()
    {
        return name;
    }

    public void setCompany(string newCompany)
    {
        company = newCompany;
    }

    public string getCompany()
    {
        return company;
    }

    public void setSinging(int newSinging)
    {
        singing = newSinging;
    }

    public int getSinging()
    {
        return singing;
    }

    public void setRapping(int newRapping)
    {
        rapping = newRapping;
    }

    public int getRapping()
    {
        return rapping;
    }

    public void setDancing(int newDancing)
    {
        dancing = newDancing;
    }

    public int getDancing()
    {
        return dancing;
    }

    public void setLikability(int newLikability)
    {
        likability = newLikability;
    }

    public int getLikability()
    {
        return likability;
    }

    public void setStarPower(double newStarPower)
    {
        starPower = newStarPower;
    }

    public double getStarPower()
    {
        return starPower;
    }
}