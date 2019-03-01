using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour {

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;


    private void Start()
    {
        StartCoroutine(Type());
    }

    private void Update()
    {
       if(textDisplay.text == sentences[index])
            {
            continueButton.SetActive(true);
        }
    }

    //Creates an array for the sentences and the speed in which the sentences should be produced.
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.02f); 
        }
    }

    //creates the next sentence when "continue" has been clicked.
    public void NextSentence()
    {
        continueButton.SetActive(false);

        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());

        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }
}
