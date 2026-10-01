using UnityEngine;

public class SBallSlowerScript : MonoBehaviour
{
    public AudioClip audioClip;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.L))
        // {
        //     rigidbody2D.AddForceY(10);
        // }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obsticle"))
        {
            AudioManager.audioPlay(audioClip,true,AudioManager.audioManager.audioMixerSFX);
        }
    }
}
