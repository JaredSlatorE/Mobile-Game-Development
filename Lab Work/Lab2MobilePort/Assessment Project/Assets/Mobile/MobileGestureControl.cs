using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch; //Originally found via Ecosia Search Overview, but found on https://learn.unity.com/tutorial/namespaces aswell. Done due to UnityEngine and Ehanced Touch both using "Touch"

public class MobileGestureControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Touch.EnhancedTouchSupport.Enable();
        Touch.Touch.onFingerMove += PrintCoolText; // https://discussions.unity.com/t/enhancedtouch-in-editor-not-recognising-touch-ended-phase/787082 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrintCoolText(Finger finger)
    {
        Debug.Log("Skibidi");
    }
}
