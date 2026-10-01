using UnityEngine;
using UnityEngine.EventSystems;

public class SMainMenuAssigner : MonoBehaviour
{
    public EventSystem eventSystem;
    public GameObject target;

    void Start()
    {
        eventSystem.SetSelectedGameObject(target);
    }
}
