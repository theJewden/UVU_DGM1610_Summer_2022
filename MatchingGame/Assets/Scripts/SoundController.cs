using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public GameObject audioController;

    private void Awake()
    {
        audioController = GameObject.Find("AudioController");
    }

    public void PlaySound(string sound)
    {
        audioController.GetComponent<AudioController>().Play(sound);
    }
}
