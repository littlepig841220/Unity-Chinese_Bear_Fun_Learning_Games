using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Network : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
        
        StartCoroutine(GetText());


    }
	
	// Update is called once per frame
	void Update () {
        //GetText();
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

            // Or retrieve results as binary data
            //byte[] results = www.downloadHandler.data;
        }
    }


}
[System.Serializable]
public class SentenceClass
{
    public string Sentence;
    public string[] Answer;

    public  SentenceClass CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<SentenceClass>(jsonString);
    }
}
