using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    int guess = (1000 + 1) / 2;
    [SerializeField] Text guessText;



    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = max + 1;
        guess = (max + min) / 2;
        guessText.text = guess.ToString();

    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}
