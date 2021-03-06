using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Day1Mid : MonoBehaviour
{
    public TextMeshProUGUI text;

    public AudioSource airConditioner;

    public float fadeInSpeed = 1f;
    public float fadeOutSpeed = 5f;

    private bool airConditionerTurnedOff = false;

    void Update()
    {
        if (!airConditionerTurnedOff && airConditioner.volume < 1f)
        {
            airConditioner.volume += Time.deltaTime * fadeInSpeed;
        }
        else if (airConditionerTurnedOff && airConditioner.volume > 0.0f)
        {
            airConditioner.volume -= Time.deltaTime * fadeOutSpeed;
        }
    }

    public void OnChangeTextStart(int progress)
    {
        switch (progress)
        {
            default:
                break;
        }
    }
    public void OnChangeTextEnd(int progress)
    {
        switch (progress)
        {
            case 2:
                airConditionerTurnedOff = true;
                Camera.main.backgroundColor = Color.black;
                text.color = Color.white;
                break;
            default:
                break;
        }
    }
}