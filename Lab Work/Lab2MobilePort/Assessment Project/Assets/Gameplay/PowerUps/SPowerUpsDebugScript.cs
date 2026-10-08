using UnityEngine;

public class SPowerUpsDebugScript : MonoBehaviour
{
    public PowerUpManager powerUpManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            powerUpManager.addPowerUp(new Yuyuko(5), true);
            // powerUpManager.addPowerUp(new GamerPowerUp(10,0.5f,"Pro"),false);
            
        }
    }
}
