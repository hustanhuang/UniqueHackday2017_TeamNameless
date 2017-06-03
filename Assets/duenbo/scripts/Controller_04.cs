using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_04 : MonoBehaviour {

    private float timer;
    public Text MainText;
    public Text NoteText;
    public GameObject helper04;
	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer>1f)
        {
            MainText.text = "“夏蚊成雷，私拟作群鹤舞于空中，心之——“";
            NoteText.text = "提示：按住鼠标，并在在开始计时8秒至9秒之间松开。（准时松开即代表打死蚊子）按下鼠标，";
            helper04.SetActive(true);
        }
	}
}
