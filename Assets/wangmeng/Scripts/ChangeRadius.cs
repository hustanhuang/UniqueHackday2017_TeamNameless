﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ChangeRadius : MonoBehaviour
{

    // Use this for initialization
    public static ChangeRadius changeRadius;
    private Vector3 mousePositon
    {
        get
        {
            return Input.mousePosition;
        }
    }


    public Vector3 targetPosition;

    private Vector3 movePosition;

    public float delayTime = 3f;

    private TextRotation[] textRotation
    {

        get
        {
            return GetComponentsInChildren<TextRotation>();
        }
    }


    public bool Reading = false;

    void Awake()
    {
        changeRadius = this;

    }
    void Start()
    {
        Vector3 tmp = (Vector3.one + Random.insideUnitSphere) / 2;
        targetPosition = new Vector3(tmp.x * Screen.width, tmp.y * Screen.height, 0.0f);
        //print(targetPosition);
        // Cursor.visible=false;

    }

    // Update is called once per frame


    void Update()
    {

        if (Reading)

            return;
        movePosition = Vector3.Lerp(movePosition, mousePositon, Time.deltaTime * delayTime);



        for (int i = 0; i < textRotation.Length; i++)
        {
            textRotation[i].trueRadius = textRotation[i].radios * (movePosition - targetPosition).magnitude / 1000;
            textRotation[i].rotateSpeed = 1 / (movePosition - targetPosition).magnitude * 1000;
        }



        //	print(movePosition);
    }

    public void ChangePos()
    {
        Reading = false;
        float posx = Random.Range(0, Screen.width);
        float posy = Random.Range(0, Screen.height);

        DOTween.To(() => targetPosition, x => targetPosition = x, new Vector3(posx, posy, 0), 1f);

        print(posx + " " + posy);
    }
}
