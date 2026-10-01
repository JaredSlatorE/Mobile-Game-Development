using UnityEngine;

public class ScoreMultiplierCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PowerUpManager>().addPowerUp(new ScoreBoost(5,2), true);
            ScoreManager.singleton.addScore(10);
            // AudioManager.audioPlay(Instantiate(Resources.Load<AudioClip>("Music/478338__joao_janz__bouncing-power-up-1_1")),true,AudioManager.audioManager.audioMixerSFX);
            Destroy(gameObject);
        }
    }
}
