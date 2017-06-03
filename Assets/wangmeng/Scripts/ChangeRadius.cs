using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRadius : MonoBehaviour {

	// Use this for initialization
    private Vector3 mousePositon
	{
		get{
			return Input.mousePosition;
		}
	} 


    public Vector3 targetPosition;

	private Vector3 movePosition;

	public float delayTime=3f;

	private TextRotation[] textRotation{
		
		get{
			return GetComponentsInChildren<TextRotation>();
		}
	}


	void Start () {
		targetPosition=new Vector3(Screen.width/2,Screen.height/2,0);
		//print(targetPosition);


	}
	
	// Update is called once per frame

	
	void Update () {
		movePosition=Vector3.Lerp(movePosition,mousePositon,Time.deltaTime*delayTime);

         

	   for(int i=0;i<textRotation.Length;i++)
	   {
		   textRotation[i].trueRadius=textRotation[i].radios*(movePosition-targetPosition).magnitude/1000;
	   }
     


	//	print(movePosition);
	}
}
