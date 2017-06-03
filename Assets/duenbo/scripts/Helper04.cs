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
            MainText.text = "";
            isStart = true;
            isMouseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            if (isStart)
            {
                camera.DOShakePosition(1, new Vector3(3, 3, 0));
                isStart = false;

                

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
                else
                {
                    MainText.text = "“夏蚊成雷，私拟作群鹤舞于空中，心之——“";
                    NoteText.text = "提示：按住鼠标，并在在开始计时8秒至9秒之间松开。（准时松开即代表打死蚊子）按下鼠标，";
                }
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
            if(timer>4)
            {
                MainText.text = "";
            }

        }
    }
}
