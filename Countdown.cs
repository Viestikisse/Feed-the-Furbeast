using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 30;
    public bool takingAway = false;

    public static bool GameIsOver = false;
    public GameObject gameOverMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "" + secondsLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if (secondsLeft <= 0)
        {
            if (GameIsOver)
            {
                StageCleared();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsOver = true;
    }

    void StageCleared()
    {
        Time.timeScale = 0f;
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<Text>().text = "" + secondsLeft;
        takingAway = false;
    }
}
