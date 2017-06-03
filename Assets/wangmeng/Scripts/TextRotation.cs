using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRotation : MonoBehaviour {

	// Use this for initialization
	public float radios=50;
     public float trueRadius;
	public float angle=0;


	public float rotateSpeed=1;

	


	
	public virtual void Start () {
		
	}
	
	// Update is called once per frame
	 public virtual void Update () {
		if(trueRadius<3)radios=0;
	}

	
}
