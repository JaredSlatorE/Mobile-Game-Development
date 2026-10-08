using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class SSoundMixerManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void setSFXVolume(float level)
    {
        audioMixer.SetFloat("SFX",level);
    }
    public void setBackgroundVolume(float level)
    {
        audioMixer.SetFloat("Background",level);
    }
}
