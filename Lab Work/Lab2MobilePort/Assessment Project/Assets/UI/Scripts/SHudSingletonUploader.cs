using UnityEngine;

public class SHudSingletonUploader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIManager.singleton.HUD = gameObject;
        UIManager.singleton.PowerUpContainer = GameObject.Find("PowerUpsUIContainer");
        print(UIManager.singleton.PowerUpContainer);
    }
}
