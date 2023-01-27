using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore_list : MonoBehaviour
{
    public GameObject Highscore;
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        Highscore.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           if(isPaused)
            {
                ResumeGame();
            }
           else
            {
                PauseGame();
            }
        }
         void PauseGame()
        {
            Highscore.SetActive(true);
        }
        void ResumeGame()
        {
            Highscore.SetActive(false);
        }
    }
}
