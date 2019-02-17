using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final9Trigger : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(Begin());
    }

    IEnumerator Begin()
    {
        yield return null;
        TriggerDialogue();
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<SetFinal9>().StartDialogue();
    }
}
