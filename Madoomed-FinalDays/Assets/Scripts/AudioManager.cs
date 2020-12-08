using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    public new AudioSource audio;

    public void Play(AudioClip sfxToPlay)
    {
        if (audio.isPlaying)
        {
            audio.Stop();
        }

        audio.clip = sfxToPlay;
        audio.Play();
    }
}