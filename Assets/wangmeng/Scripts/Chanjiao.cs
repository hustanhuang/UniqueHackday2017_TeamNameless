using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chanjiao : MonoBehaviour {

	// Use this for initialization
	float time;
	float randomTime;
	void Start () {
		time=Time.time;
		randomTime=Random.Range(20,25);
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time-time>=randomTime)
		{
                   

           
                ChangeRadius.changeRadius.ChangePos();
                      
				Debug.Log("蝉叫");



                   time=Time.time;
				   randomTime=Random.Range(20,25);
		}
	}
}
