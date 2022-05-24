using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour {

    public Text score_view2;
    public Text correct;
    public Text mistake;
    public Text error;

    private void Start()
    {
        score_view2.text = "Your score : " + Value.score;

        int b = Value.s -1;
        correct.text = "Correct : " + b;

        mistake.text = "Mistake : " + Value.m;

        //float a = Value.m/ (10 + Value.m)*100;
        decimal result = System.Math.Round((decimal)Value.m / (10 + Value.m)*100, 2);
        //print(a);

        error.text = "Error rate : " + result + " %";
    }

    public void menu()
    {
        StartCoroutine(wait1());
        
    }

    public void restart()
    {
        StartCoroutine(wait2());
        
        
    }

    public void gameend()
    {
        StartCoroutine(wait3());
        
    }

    IEnumerator wait1()
    {

        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Menu");
        Value.score = 0;
        Value.s = 1;
        Value.m = 0;
    }

    IEnumerator wait2()
    {

        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Game");
        Value.score = 0;
        Value.s = 1;
        Value.m = 0;

    }

    IEnumerator wait3()
    {

        yield return new WaitForSeconds(2);
        Application.Quit();

    }
}
