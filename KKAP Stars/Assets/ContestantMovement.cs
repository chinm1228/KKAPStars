using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContestantMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool isWalker = false;

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            isWalker = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isWalker)
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (this.transform.position.x > 10)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
