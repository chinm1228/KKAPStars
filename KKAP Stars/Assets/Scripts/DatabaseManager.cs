using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ContestantDatabase database;
    public static DatabaseManager instance = null;

    void Awake()
    {
        database = new ContestantDatabase();
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else if(instance  != this)
        {
            Destroy(gameObject);
        }   
    }
}
