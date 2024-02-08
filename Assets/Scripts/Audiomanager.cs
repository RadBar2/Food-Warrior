using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{

    public static Audiomanager instance;
    private AudioSource audio;

    // Start is called before the first frame update
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        audio = GetComponent<AudioSource>();
    }

    public void Play(AudioClip clip, float pitch = 1, float volume = 0.5f)
    {
        audio.pitch = pitch;
        audio.volume = volume;

        audio.PlayOneShot(clip);
    }
}
