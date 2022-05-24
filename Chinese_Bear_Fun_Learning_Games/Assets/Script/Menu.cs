using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void gamestart()
    {
        StartCoroutine(wait1());
        
    }

    public void gameend()
    {
        StartCoroutine(wait2());
    }

    IEnumerator wait1()
    {
        
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Game");
        Value.score = 0;
        Value.s = 1;
        Value.m = 0;
    }

    IEnumerator wait2()
    {

        yield return new WaitForSeconds(2);
        Application.Quit();

    }
}
