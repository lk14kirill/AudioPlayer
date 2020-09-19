using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class aa : MonoBehaviour
{
    public AudioMixer auMixer;
    public Text txt;
    public Slider sldr;

    // Start is called before the first frame update
    void Start()
    {
        txt.text = sldr.value + "";
    }
    public void SetVolume()
    {
        txt.text = sldr.value + "";
        auMixer.SetFloat("volume", sldr.value);
    }
}
