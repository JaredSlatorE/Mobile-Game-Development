using UnityEngine;

public class SAddBoostPowerUp : MonoBehaviour
{
    public int boostAddAmount = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<SPlayerBoostScript>().boostCount += 1;
            // AudioManager.audioPlay(Instantiate(Resources.Load<AudioClip>("Music/478338__joao_janz__bouncing-power-up-1_1")),true,AudioManager.audioManager.audioMixerSFX);
            Destroy(gameObject);
        }
    }
}
