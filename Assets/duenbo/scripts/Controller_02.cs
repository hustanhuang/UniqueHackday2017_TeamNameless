using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_02 : MonoBehaviour {

    private float timer;

    public Text UIText;

    public Text NoteText;

    public GameObject ClipHelper;
    private bool isMouseDown = false;
    private AudioSource audio;
    public bool stopSound = false;
    private bool IsPlayed = false;
    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 8f)
        {
            if (!IsPlayed)
            {
                audio.Play();
                IsPlayed = true;
            }
            
            NoteText.text = "提示：按下鼠标左键并向右滑动（表示手臂向右挥动）";
            ClipHelper.SetActive(true);
        }
        if (stopSound)
        {
            audio.Stop();
        }

    }
}