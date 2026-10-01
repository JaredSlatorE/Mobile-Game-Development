using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

    public static AudioManager audioManager;
    public AudioClip backgroundMusic;
    public AudioMixerGroup audioMixerBackground;
    public AudioMixerGroup audioMixerSFX;
    public static AudioSource backgroundMusicSource;

    void Awake()
    {
        if(audioManager == null)
        {
            audioManager = this;
        }
    }
    public void Start()
    {
        backgroundMusicSource = audioPlay(backgroundMusic, false, audioMixerBackground);
        backgroundMusicSource.loop = true;
        SceneManager.sceneLoaded += onSceneChange;
    }
    public static AudioSource audioPlay(AudioClip clip, bool shouldDelete, AudioMixerGroup audioMixerGroup)
    {
        GameObject audioObject = Instantiate(Resources.Load<GameObject>("Music/AudioObject"));
        AudioSource audioSource = audioObject.GetComponent<AudioSource>();

        audioSource.clip = clip;
        audioSource.outputAudioMixerGroup = audioMixerGroup;
        audioSource.Play();

        if (shouldDelete)
        {
            Destroy(audioObject,clip.length);
        }
        return audioSource;
    }

    public static void changeBackgroundMusic(AudioClip clip)
    {
        backgroundMusicSource.Stop();
        backgroundMusicSource.clip = clip;
        backgroundMusicSource.Play();

    }
    private void onSceneChange(Scene scene, LoadSceneMode loadSceneMode)
    {
        backgroundMusicSource = audioPlay(backgroundMusic, false,audioMixerBackground);
        backgroundMusicSource.loop = true;
        backgroundMusicSource.Play();
    }
    
}
