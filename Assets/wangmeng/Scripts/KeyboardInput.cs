using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour {

	// Use this for initialization
	public KeyCode getFan;
	public bool  canGet=true;

	private FanAnim fanAnim;
	void Start () {
		fanAnim=GetComponent<FanAnim>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!canGet)
		return;



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
