using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject databaseManager;

    void Awake()
    {
        if(DatabaseManager.instance == null)
        {
            Instantiate(databaseManager);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
