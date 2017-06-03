using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRotation : MonoBehaviour {

	// Use this for initialization
	public float radios=50;
     public float trueRadius;
	public float angle=0;


	public float rotateSpeed=1;

	

    private float beginTime;
	private float readTime=0;

	
	public virtual void Start () {
		beginTime=Time.time;
		//readTime=Time.time;
	}
	
	// Update is called once per frame
	 public virtual void Update () {
		if(trueRadius<1){
			trueRadius=0;
		    ChangeRadius.changeRadius.Reading=true;
          readTime=Time.time-readTime;

		Debug.Log("胜利");
		
		}
	}

	
}
