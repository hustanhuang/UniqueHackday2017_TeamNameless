using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour {


    private float timer;

    public Sprite middle;
    
    public Sprite End;

    public SpriteRenderer background;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer>0.5f)
        {
            background.sprite = middle;
        }
        if(timer>2f)
        {
            background.sprite = End;
            
        }
        if (timer > 6f)
        {
            Application.LoadLevel(0);
        }
	}
}
