using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangScript : MonoBehaviour {

    public float speed = 2f;

    private Vector3 bangTranslate;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate  (new Vector3(0, 0, Time.deltaTime * speed));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * speed * (-1)));
        }
        
        //transform.Rotate(bangTranslate);
	}
}
