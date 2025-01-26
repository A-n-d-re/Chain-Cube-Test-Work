using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using YG;

public class AudioActivator : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundMusic;

    private void Start()
    {
        if (YG2.GetState("IsMusicOff") == 0)
        {
            backgroundMusic.Play();
        }
        else
        {
            backgroundMusic.Stop();
        }
    }
}
