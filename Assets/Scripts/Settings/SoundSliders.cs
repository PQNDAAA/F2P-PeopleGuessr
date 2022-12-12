using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

[RequireComponent(typeof(Slider))]
public class SoundSliders : MonoBehaviour
{
    Slider slider
    {
        get { return GetComponent<Slider>(); }
    }
    public AudioMixer audioMixer;
    public string volumeName;
    

    public void UpdateValue(float value)
    {
        audioMixer.SetFloat(volumeName, value);
    }
    
}
