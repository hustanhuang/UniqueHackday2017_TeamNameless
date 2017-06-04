using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRotation : MonoBehaviour
{

    // Use this for initialization
    public float radios = 50;
    public float trueRadius;
    public float angle = 0;


    public float rotateSpeed = 1;



    private float beginTime;
    private float readTime = 0;


    public virtual void Start()
    {
        beginTime = Time.time;
        //readTime=Time.time;
    }
    bool succeed = false;
    // Update is called once per frame
    public virtual void Update()
    {
        if (trueRadius < 1)
        {
            // succeed=true;
            readTime = Time.time - readTime;

            if (succeed) return;
            succeed = true;
            trueRadius = 0;
            ChangeRadius.changeRadius.Reading = true;

            GameObject.Find("Managers").GetComponent<SceneSwitcher>().Goto("Day1Mid");
        }
        else setFalse();
    }
    public void setFalse()
    {
        succeed = false;
    }


}
