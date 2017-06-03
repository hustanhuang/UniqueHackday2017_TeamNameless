using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour {

	// Use this for initialization
	public KeyCode getFan;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(getFan))
        {
            Debug.Log("拿起扇子");
        } 
        if (Input.GetKeyUp(getFan))
        {
            Debug.Log("放下扇子");
        }
     
	}
}
