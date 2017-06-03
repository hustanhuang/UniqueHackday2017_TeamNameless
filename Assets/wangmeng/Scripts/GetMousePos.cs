using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePos : MonoBehaviour {

	// Use this for initialization

	public Vector3 nowMousePos;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		nowMousePos=Input.mousePosition;
	}
}
