using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager singleton;
    public GameObject HUD; //Uploaded by the HUD ingame
    public GameObject PowerUpContainer;

    void Awake()
    {
        singleton = this;
    }
}
