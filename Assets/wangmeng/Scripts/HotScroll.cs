using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public enum ScrollbarType
{
	adding,
	pausing,
	producting
}
public class HotScroll : MonoBehaviour {




	// Use this for initialization
    public ScrollbarType scrollbarType=ScrollbarType.pausing;
	private float time;
	public float addSpeed=0.01f;
    
	public float productSpeed=0.02f;
	private float number{
		get {
			return GetComponent<Scrollbar>().size;
		}
		set
		{
			GetComponent<Scrollbar>().size=value;
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(scrollbarType==ScrollbarType.pausing)
		return;

		if(scrollbarType==ScrollbarType.adding)
		{
			number+=addSpeed;
		}
        
 	     if(scrollbarType==ScrollbarType.producting)
		{
			number-=productSpeed;
		}
         
        

		if(number==1)
	       Death();
		
        
		
	}
   
    

	void Death()
	{
	   Debug.Log("失败");
	}

	
}
