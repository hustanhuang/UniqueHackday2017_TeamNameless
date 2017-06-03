using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Helper04 : MonoBehaviour {

    public Text MainText;

    public Text NoteText;

    public Transform camera;

    public GameObject target;

    private bool isMouseDown = false;
    
    private bool isStart=false;

    private float timer=0;

    private AudioSource audio;

    private bool isPlay = false;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            NoteText.text = "";
            isStart = true;
            isMouseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            camera.DOShakePosition(1, new Vector3(3, 3, 0));
            isStart = true;
            
            isMouseDown = false;
            
            if (!isPlay)
            {
                audio.Play();
                isPlay = true;
            }
            if (8 < timer && timer < 9)
            {
                target.SetActive(true);
                gameObject.SetActive(false);
            }

        }
        if (isStart&&isMouseDown)
        {
            timer += Time.deltaTime;
            if(timer>1)
            {
                MainText.text = "1";
            }
            if(timer>2)
            {
                MainText.text = "2";
            }
            if(timer>3)
            {
                //isPlay = false;
                MainText.text = "3";
            }

        }
    }
}
