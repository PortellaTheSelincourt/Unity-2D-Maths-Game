using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ChangeMusicVol : MonoBehaviour
{

    public Slider Volume;
    public AudioSource myMusic;

    // Update is called once per frame
    void Update()
    {
        myMusic.volume = Volume.value;
    }
}
