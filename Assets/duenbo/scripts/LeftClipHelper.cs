using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LeftClipHelper : MonoBehaviour {

    public GameObject Controller02;

    public GameObject Controller01;

    public GameObject wind;
    public Text MainText;
    public Text NoteText;
    private bool isMouseDown = false;

    private float x = 0;//横向位移长度
    private AudioSource audio;
    private bool isPlayed=false;
    Vector3 lastMousePosition = Vector3.zero;
	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            lastMousePosition = Vector3.zero;
        }

        if (isMouseDown)
        {
            if (lastMousePosition != Vector3.zero)
            {
                
                Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastMousePosition;
                x += offset.x;
                
               
            }
            lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (x < -8f)
        {
            if (!isPlayed)
            {
                audio.Play();
                isPlayed = true;
            }
            wind.transform.DOMove(new Vector3(-10, 0, 0), 0.3f).SetDelay(0.2f);
            Controller01.GetComponent<Controller_01>().stopSound = true;
            MainText.text = "";
            NoteText.text = "";
            Controller02.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}
