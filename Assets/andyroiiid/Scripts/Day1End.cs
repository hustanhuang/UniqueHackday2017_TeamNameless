using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1End : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip doorKnockSound;
    public AudioClip openDoorSound;
    public AudioClip closeDoorSound;

    public void OnChangeTextStart(int progress)
    {
        switch (progress)
        {
            case 0:
                audioSource.PlayOneShot(doorKnockSound);
                break;
            case 2:
                audioSource.PlayOneShot(openDoorSound);
                break;
            default:
                break;
        }
    }
    public void OnChangeTextEnd(int progress)
    {
        switch (progress)
        {
            case 5:
                audioSource.PlayOneShot(closeDoorSound);
                break;
            default:
                break;
        }
    }
}