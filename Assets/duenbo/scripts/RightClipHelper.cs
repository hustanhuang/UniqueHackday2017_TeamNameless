using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class RightClipHelper : MonoBehaviour {

    public GameObject Controller02;

    public GameObject Controller03;

    public GameObject wind;
    public Text MainText;
    public Text NoteText;
    private bool isMouseDown = false;

    private float x = 0;//横向位移长度
    private AudioSource audio;
    private bool isPlayed = false;
    Vector3 lastMousePosition = Vector3.zero;
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

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

        if (x > 8f)
        {
            if (!isPlayed)
            {
                audio.Play();
                isPlayed = true;
            }
            wind.transform.DOMove(new Vector3(10, 0, 0), 0.3f).SetDelay(0.2f);
            Controller02.GetComponent<Controller_02>().stopSound = true;
            MainText.text = "";
            NoteText.text = "";
            Controller03.SetActive(true);
        }
    }

}