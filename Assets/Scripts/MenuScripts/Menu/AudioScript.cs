using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private AudioSource Music;

    float ValueMusicSlider = 1f;

    float ValueFXSlider = 1f;

    void Start()
    {
        Music = GetComponent<AudioSource>();
    }

    void Update()
    {
        Music.volume = ValueMusicSlider;
    }

    public void SetVolumeMusic(float vol)
    {
        ValueMusicSlider = vol;
    }

    public void SetVolumeFX(float vol)
    {
        ValueFXSlider = vol;
    }

}
