using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMusic : MonoBehaviour
{
    public bool toPlay = true;

    void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            GameObject music = GameObject.FindGameObjectWithTag("Music");
            Destroy(music);
        }
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
