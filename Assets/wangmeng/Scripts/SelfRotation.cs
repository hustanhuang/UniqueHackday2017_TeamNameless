using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotation : TextRotation {

	// Use this for initialization
	private Vector3 postion{
		get
		{
			return transform.localPosition;
		}
		set
		{
			transform.localPosition=value;
		}
	}



	private Vector3 initPos;
	
	//private float trueRadius;
	void Start () {
		initPos=postion;
		angle=(int)Random.Range(0,359);
		trueRadius=radios;
		//print(Mathf.Cos(3.1415f));
	}
	
	// Update is called once per frame
	void Update () {



		postion=new Vector3(initPos.x+trueRadius* Mathf.Cos(angle/180*3.141f),initPos.y+trueRadius* Mathf.Sin(angle/180*3.141f),postion.z);
		angle=(angle+rotateSpeed)%360;


	}
}
