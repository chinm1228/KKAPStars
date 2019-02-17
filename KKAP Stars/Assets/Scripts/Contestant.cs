using UnityEngine;
using UnityEngine.UI;

public class Contestant
{
    private string name;
    private string company;
    private int singing;
    private int rapping;
    private int dancing;
    private double starPower;

    public Contestant(string newName, string newCompany, int newSinging, int newRapping, int newDancing, double newStarPower)
    {
        name = newName;
        company = newCompany;
        singing = newSinging;
        rapping = newRapping;
        dancing = newDancing;
        starPower = newStarPower;
    }

    public void SetName(string newName)
    {
        name = newName;
    }

    public string GetName()
    {
        return name;
    }

    public void SetCompany(string newCompany)
    {
        company = newCompany;
    }

    public string GetCompany()
    {
        return company;
    }

    public void SetSinging(int newSinging)
    {
        singing = newSinging;
    }

    public int GetSinging()
    {
        return singing;
    }

    public void SetRapping(int newRapping)
    {
        rapping = newRapping;
    }

    public int GetRapping()
    {
        return rapping;
    }

    public void SetDancing(int newDancing)
    {
        dancing = newDancing;
    }

    public int GetDancing()
    {
        return dancing;
    }

    public void SetStarPower(double newStarPower)
    {
        starPower = newStarPower;
    }

    public double GetStarPower()
    {
        return starPower;
    }
}