using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chanjiao : MonoBehaviour
{
    public AudioSource sound;

    // Use this for initialization
    float time;
    float randomTime;
    void Start()
    {
        time = Time.time;
        randomTime = Random.Range(5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - time >= randomTime)
        {



            ChangeRadius.changeRadius.ChangePos();

            sound.Play();

            time = Time.time;
            randomTime = Random.Range(20, 25);
        }
    }
}
