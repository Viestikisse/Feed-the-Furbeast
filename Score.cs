using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int Scores;
    public Text ScoreText;

    public static bool StageIsCleared = false;
    public GameObject stageClearedMenuUI;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Scores >= 500)
        {
            if (StageIsCleared)
            {
                StageCleared();
            } else
            {
                Pause();
            }
        }
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Pause()
    {
        stageClearedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        StageIsCleared = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        StageIsCleared = false;
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game2");
        StageIsCleared = false;
        Time.timeScale = 1f;
    }

    void StageCleared()
    {
        Time.timeScale = 0f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Icecream")
        {
            other.gameObject.SetActive(false);
            Scores = 4 + Scores; // to make the score increasing by 5
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Cake")
        {
            other.gameObject.SetActive(false);
            Scores = 9 + Scores; // to make the score increasing by 10
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Muffin")
        {
            other.gameObject.SetActive(false);
            Scores = 14 + Scores; // to make the score increasing by 15
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Candy")
        {
            other.gameObject.SetActive(false);
            Scores = 19 + Scores; // to make the score increasing by 20
            Destroy(other.gameObject);
        } 
        AddScore();
    }

    void AddScore()
    {
        Scores++;
        ScoreText.text = Scores.ToString();
        FindObjectOfType<AudioManager>().Play("Mlem");
    }
}
