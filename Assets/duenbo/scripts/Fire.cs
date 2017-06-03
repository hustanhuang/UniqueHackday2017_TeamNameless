using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour {

    public Image ScrollImage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
           
            print(Input.mousePosition);
           // ScrollImage.fillAmount = ScrollImage.fillAmount - 0.05f;
        }
	}
}
