using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_05 : MonoBehaviour {

    public Text MainText;

    public Text NoteText;

    private float timer=0;

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer < 1f)
        {
            MainText.text = "解决";
        }
        else if (timer > 2f)
        {
            MainText.text = "夏蚊成雷，私拟作群鹤舞于空中，心之所向，则或千或百，果然…鹤…也……鼾声响起，鼾声逐渐变小直至消失";
        }
	}
}
