using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text score_view;
    public Text mistake;
    
    //public int score = 0;

    private void Start()
    {
        score_view.text = "Score : " + Value.score;
    }

    public void Scoreadd()
    {
        Value.score += 30;
        score_view.text = "Score : " + Value.score;
        //Application.LoadLevel(Application.loadedLevel);
        Value.s +=1;
    }

    public void Scoredecrease()
    {
        Value.score -= 30;
        score_view.text = "Score : " + Value.score;
        //Application.LoadLevel(Application.loadedLevel);
        Value.m += 1;
        mistake.text = "Mistake:" + Value.m;
    }
}
