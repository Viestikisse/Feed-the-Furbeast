using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject playgameButton;
    public GameObject optionButton01;
    public GameObject optionButton02;
    public GameObject optionButton03;
    public GameObject optionButton04;
    public GameObject optionButton05;
    public GameObject optionButton06;
    public GameObject optionButton07;
    public GameObject optionButton08;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
    }

    private void Update()
    {
        if (textDisplay.text == sentences[5])
        {
            playgameButton.SetActive(true);
        }

        if (textDisplay.text == sentences[0])
        {
            optionButton01.SetActive(true);
        }

        if (textDisplay.text == sentences[0])
        {
            optionButton02.SetActive(true);
        }

        if (textDisplay.text == sentences[1])
        {
            optionButton03.SetActive(true);
        }

        if (textDisplay.text == sentences[2])
        {
            optionButton04.SetActive(true);
        }

        if (textDisplay.text == sentences[2])
        {
            optionButton05.SetActive(true);
        }

        if (textDisplay.text == sentences[3])
        {
            optionButton06.SetActive(true);
        }

        if (textDisplay.text == sentences[3])
        {
            optionButton07.SetActive(true);
        }

        if (textDisplay.text == sentences[4])
        {
            optionButton08.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        } else
        {
            textDisplay.text = "";
        }

        optionButton01.SetActive(false);
        optionButton02.SetActive(false);
        optionButton03.SetActive(false);
        optionButton04.SetActive(false);
        optionButton05.SetActive(false);
        optionButton06.SetActive(false);
        optionButton07.SetActive(false);
        optionButton08.SetActive(false);
        playgameButton.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
