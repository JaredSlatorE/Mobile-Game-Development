using UnityEngine;

public class SYuyuokoPowerUp : MonoBehaviour
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
            collision.GetComponent<PowerUpManager>().addPowerUp(new Yuyuko(10),false);
            AudioManager.changeBackgroundMusic(Instantiate(Resources.Load<AudioClip>("Music/Dark Side Of Fate")));
            Destroy(gameObject);
        }
    }
}
