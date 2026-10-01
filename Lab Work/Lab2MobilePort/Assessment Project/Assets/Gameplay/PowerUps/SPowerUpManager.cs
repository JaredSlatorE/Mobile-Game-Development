using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PowerUpManager : MonoBehaviour
{
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneChange;
    }
    public List<PowerUp> activePowerUps = new List<PowerUp>();

    public bool addPowerUp(PowerUp powerUp, bool allowDuplicate)
    {
        if (!allowDuplicate && isPowerUpActive(powerUp.PTag)) //Check if there is a powerup of that name currently active
        {
           if (isPowerUpActive(powerUp.PTag))
            {
                print("A powerup of that already exists!");
                return false;
            }
        }

        activePowerUps.Add(powerUp);
        powerUp.owner = gameObject;
        powerUp.onActive();

        if (powerUp.imagePath != "" && powerUp.duration > 0) //Checks if there is a valid imagePath and a duration to maek sure its not creating the ui when it shouldnt
        {
            PowerUpsUIMananger.addPowerUpUI(new PowerUPUIInfo(powerUp.imagePath,powerUp.duration));
        }
        return true;
    }

    public bool isPowerUpActive(string powerUpTag) //Check if there is a powerup active in the list;
    {
        for(int i = 0; i < activePowerUps.Count; i++)
        {
            if (activePowerUps[i].PTag == powerUpTag)
            {
                return true;
            }
        }
        return false;
    }

    public bool clearAllPowerUps()
    {
        for (int i = 0; i <activePowerUps.Count; i++)
        {
            activePowerUps[i].onDeactive();
        }
        activePowerUps.Clear();
        return true;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < activePowerUps.Count; i++)
        {
            bool shouldCancel = activePowerUps[i].timer();
            if (shouldCancel)
            {
                //print($"{activePowerUps[i].PTag} Removed");
                activePowerUps[i].onDeactive();
                activePowerUps.RemoveAt(i);
            }
            
        }
    }

    

    void OnSceneChange(Scene scene, LoadSceneMode sceneMode)
    {
        clearAllPowerUps();
    }
}
