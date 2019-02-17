using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFinal9 : MonoBehaviour
{
    private Contestant[] finalists = new Contestant[9];
    private ContestantDatabase cdb = new ContestantDatabase();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Contestant[] DetermineFinalists()
    {
        return finalists;
    }
}
