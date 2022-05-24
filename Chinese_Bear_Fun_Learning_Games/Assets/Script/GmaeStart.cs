using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class GmaeStart : MonoBehaviour {

    public Text object1;
    public Text object2;
    public Text object3;
    public Text object4;
    public Text object5;
    public Text s_view;
    public Text question;

    

    // Use this for initialization
    void Start () {

        gamestart();
        
    }
	
	// Update is called once per frame
	void Update () {
        if(Value.s > 10)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }

    IEnumerator GetText()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://chinf.me/sentence");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {

            string jsonString = www.downloadHandler.text;
            // Show results as text
            Debug.Log(jsonString);

            SentenceClass s = JsonUtility.FromJson<SentenceClass>(jsonString);


            Debug.Log(s.Sentence);
            Debug.Log(s.Answer[0]);

            question.text = s.Sentence;

            string[] choose = { "把", "本", "筆", "部", "場", "副", "床", "層", "次", "簇", "滴", "點", "疊", "番" , "份" , "峰" ,"幅" , "服" ,
                                "桌" , "台" , "頭" , "灘" , "輛" , "套" , "列" , "對" , "冊"};

            string ans = s.Answer[0];

            choose = choose.Where(val => val != ans).ToArray();

            int a = choose.Length;

            print(a);

            int[] randomArray = new int[5];

            for (int i = 0; i <= 4; i++)
            {
                randomArray[i] = UnityEngine.Random.Range(0, a);
            }

            object1.text = choose[randomArray[0]];
            object2.text = choose[randomArray[1]];
            object3.text = choose[randomArray[2]];
            object4.text = choose[randomArray[3]];
            object5.text = ans;

            s_view.text = Value.s + "/10";

            // Or retrieve results as binary data
            //byte[] results = www.downloadHandler.data;
        }
    }

    public void gamestart()
    {
        StartCoroutine(GetText());
    }
    public class SentenceClass
    {
        public string Sentence;
        public string[] Answer;

        public SentenceClass CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<SentenceClass>(jsonString);
        }
    }
}
//[System.Serializable]

