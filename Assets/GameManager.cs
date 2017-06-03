using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    private float timer;

    public Text windText;

    public float exchangeTime=5f;

    public float WindRange = 1;

    public Rigidbody2D ballRd;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        int index = (int)(timer / exchangeTime);
        int count = index % 3;
        switch (count){
            case 0:
                {
                    windText.text = "风停了";
                    break;
                }
            case 1:
                {
                    windText.text = "刮东风了";
                    ballRd.AddForce(new Vector2(WindRange, 0));
                    break;
                }
            case 2:
                {
                    windText.text = "刮西风了";
                    ballRd.AddForce(new Vector2(-WindRange, 0));
                    break;
                }
        }
	}
}
