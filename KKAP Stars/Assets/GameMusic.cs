using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public bool toPlay = true;

    void Awake()
    {
        if (toPlay)
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioController>().PlayMusic();
        }
        else
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioController>().StopMusic();
        }
    }

}
