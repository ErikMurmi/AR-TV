using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setVolume : MonoBehaviour
{
    public  AudioSource vp;

    public void SetLevel (float sliderValue)
    {
        vp.volume = (sliderValue);
    }
}
