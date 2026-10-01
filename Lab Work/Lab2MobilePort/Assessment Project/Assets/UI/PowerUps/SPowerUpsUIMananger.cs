
using UnityEngine.UI;
using UnityEngine;


public struct PowerUPUIInfo
{
    public string imagePath;
    public float duration;

    public PowerUPUIInfo(string ImagePath, float Duration)
    {
        duration = Duration;
        imagePath = ImagePath;
    }
}

public static class PowerUpsUIMananger
{
    private static string UIPath = "UI/PowerUpChildUI";
    private static GameObject gameHUD = UIManager.singleton.HUD;
    public static bool addPowerUpUI(PowerUPUIInfo uiInfo)
    {
        GameObject newUI = Resources.Load<GameObject>(UIPath); //Load the UI object
        GameObject instanceUI = GameObject.Instantiate(newUI); //Instance it as an object instead of prefab
        Debug.Log(instanceUI);
        instanceUI.GetComponent<Image>().sprite = Resources.Load<Sprite>(uiInfo.imagePath); //Swap the sprite with the one in the path
        instanceUI.GetComponent<PowerUPChildUIManager>().duration = uiInfo.duration;
        

        instanceUI.transform.SetParent(UIManager.singleton.PowerUpContainer.transform); //Set its parent
        instanceUI.transform.localScale = new Vector3(1,1,1); //Set its scale to fit nicely in with the parent
        return true;
    }
}
