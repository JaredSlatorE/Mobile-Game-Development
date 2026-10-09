using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class SPauseGame : MonoBehaviour
{
    private InputAction pauseKey;
    public Canvas pauseUI;
    private bool PauseUIOpen = false;

    void Start() //Find the pause action button and hide the ui
    {
        if (!pauseUI)
        {
            pauseUI = GameObject.Find("PauseUI").GetComponent<Canvas>();
        }
        EventSystem.current.sendNavigationEvents = false;
        pauseKey = InputSystem.actions.FindAction("Pause");
        pauseUI.enabled = false;
    }


    public void flipflopUI()
    {
        if (!PauseUIOpen) //Create the UI
            {
                Time.timeScale = 0;
                EventSystem.current.SetSelectedGameObject(pauseUI.transform.Find("PauseButton").transform.gameObject);
                EventSystem.current.sendNavigationEvents = true;
                PauseUIOpen = true;
            }
            else //Remove the UI
            {
                Time.timeScale = 1;
                EventSystem.current.sendNavigationEvents = false;
                PauseUIOpen = false;
            }
            pauseUI.enabled = PauseUIOpen;
    }

    public void onInput(InputAction.CallbackContext input)
    {
        if (input.started)
        {
            flipflopUI();
        }
    }
}
