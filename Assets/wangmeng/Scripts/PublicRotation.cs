using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicRotation : TextRotation {

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
	public Transform AnothorTrans;

	private Vector3 centerPosition;
	
	
	public void Start () {
		centerPosition=(transform.localPosition+AnothorTrans.localPosition)/2;
		trueRadius=radios;
	}
	
	// Update is called once per frame
	void Update () {
		
	postion=new Vector3(centerPosition.x+trueRadius* Mathf.Cos(angle/180*3.141f),centerPosition.y+trueRadius* Mathf.Sin(angle/180*3.141f),postion.z);
		angle=(angle+rotateSpeed)%360;
	}
}
