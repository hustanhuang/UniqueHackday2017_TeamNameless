using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UpClipHelper : MonoBehaviour {

    public GameObject Controller03;

    public GameObject Controller04;

    public GameObject wind;
    public Text MainText;
    public Text NoteText;
    private bool isMouseDown = false;

    private float y = 0;//纵向位移长度
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
                y += offset.y;


            }
            lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (y > 5f)
        {
            if (!isPlayed)
            {
                audio.Play();
                isPlayed = true;
            }
            wind.transform.DOMove(new Vector3(0, 7, 0), 0.3f).SetDelay(0.2f);
            Controller03.GetComponent<Controller_03>().stopSound = true;
            MainText.text = "";
            NoteText.text = "";
            Controller04.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}