using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SSoundUIButton : MonoBehaviour
{
    public Canvas SoundUICanvas;
    public Canvas UICanvas;
    public GameObject startingObject;
    public EventSystem eventSystem;

    public void onPressed()
    {
        eventSystem.SetSelectedGameObject(startingObject);
        SoundUICanvas.enabled = true;
        UICanvas.enabled = false;
        
    }
}
