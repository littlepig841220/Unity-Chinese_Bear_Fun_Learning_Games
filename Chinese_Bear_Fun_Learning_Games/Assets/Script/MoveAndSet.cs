using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndSet : MonoBehaviour {

    int ys;
    int direction, direction2, direction3;


    // Use this for initialization
    void Start () {
        positionStart();
    }
	
	// Update is called once per frame
	void Update () {

        if (direction3 == 0)
        {
            if (direction2 == 0)
            {
                if (this.transform.position.x < 1100 && this.transform.position.y < 850)
                {

                    this.transform.Translate(new Vector3(300, direction, 0) * Time.deltaTime);
                    //print(this.transform.position.x);
                }
                else
                {
                    positionStart();
                }
            }
            else if (direction2 == 1)
            {
                if (this.transform.position.x < 1100 && this.transform.position.y > -50)
                {

                    this.transform.Translate(new Vector3(300, -direction, 0) * Time.deltaTime);
                    //print(this.transform.position.x);
                }
                else
                {
                    positionStart();
                }
            }
        }
        else if (direction3 == 1)
        {
            if (direction2 == 0)
            {
                if (this.transform.position.x > -50 && this.transform.position.y < 850)
                {

                    this.transform.Translate(new Vector3(-300, direction, 0) * Time.deltaTime);
                    //print(this.transform.position.x);
                }
                else
                {
                    positionStart();
                }
            }
            else if (direction2 == 1)
            {
                if (this.transform.position.x > -50 && this.transform.position.y > -50)
                {

                    this.transform.Translate(new Vector3(-300, -direction, 0) * Time.deltaTime);
                    //print(this.transform.position.x);
                }
                else
                {
                    positionStart();
                }
            }
        }

        
        

    }

    public void positionStart()
    {
        ys = Random.Range(175,625);
        direction = Random.Range(0, 40);
        direction2 = Random.Range(0, 2);
        direction3 = Random.Range(0, 2);
        //print(direction3);
        //print(direction);
        
        //this.transform.position = new Vector3(1100, 850, 0);

        if (direction3 == 0)
        {
            this.transform.position = new Vector3(-50, ys, 0);
        }
        else if (direction3 == 1)
        {
            this.transform.position = new Vector3(1100, ys, 0);
        }
    }
}
