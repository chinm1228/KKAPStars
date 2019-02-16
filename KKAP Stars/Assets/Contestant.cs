public class Contestant
{
    private string name;
    private string company;
    private double singing;
    private double rapping;
    private double dancing;
    private double likability;
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

    public void setSinging(double newSinging)
    {
        singing = newSinging;
    }

    public double getSinging()
    {
        return singing;
    }

    public void setRapping(double newRapping)
    {
        rapping = newRapping;
    }

    public double getRapping()
    {
        return rapping;
    }

    public void setDancing(double newDancing)
    {
        dancing = newDancing;
    }

    public double getDancing()
    {
        return dancing;
    }

    public void setLikability(double newLikability)
    {
        likability = newLikability;
    }

    public double getLikability()
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