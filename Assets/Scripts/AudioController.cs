using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSourceBackgroundSound;
    public static AudioController instance;

    // Start is called before the first frame update
    void Start()
    {
        audioSourceBackgroundSound.Play();
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackgroundSoundPause()
    {
        audioSourceBackgroundSound.Stop();
    }
}
