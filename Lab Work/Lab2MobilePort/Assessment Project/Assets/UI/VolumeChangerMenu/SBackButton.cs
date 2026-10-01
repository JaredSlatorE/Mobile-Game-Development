using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SBackButton : MonoBehaviour
{
    public EventSystem eventSystem;
    public Canvas uiCanvas;
    public Canvas nextCanvas;
    public Button nextUIButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void pressed()
    {
        eventSystem.SetSelectedGameObject(nextUIButton.gameObject);
        uiCanvas.enabled = false;
        nextCanvas.enabled = true;
    }
}
