using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu_Audio : MonoBehaviour
{
    private bool toggle = true;
    public Sprite audioOn;
    public Sprite audioOff;
    public GameObject audio_image;

    public void EnableAudio()
    {
        toggle = !toggle;

        if (toggle)
        {
            AudioListener.volume = 1f;
            audio_image.GetComponent<Image>().sprite = audioOn;
        }
        else
        {
            AudioListener.volume = 0f;
            audio_image.GetComponent<Image>().sprite = audioOff;
        }
    }
}
