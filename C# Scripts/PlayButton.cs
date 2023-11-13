using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public AudioSource audioSource;
    public void Play()
    {
        audioSource.Play();
    }
}
