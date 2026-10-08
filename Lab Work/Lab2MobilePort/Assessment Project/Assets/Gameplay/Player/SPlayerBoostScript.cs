using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SPlayerBoostScript : MonoBehaviour
{
    private InputAction boostAction;
    public PowerUpManager powerUpManager;

    public int boostCount = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boostAction = InputSystem.actions.FindAction("Boost");
    }

    public void boost() //Make the player have a speed boost
    {
        if (boostCount != 0)
        {
            powerUpManager.addPowerUp(new SpeedBoost(0,1.5f),true);
            ScoreManager.singleton.addScore(5);
            boostCount--;
        }

    }
    public void onInput(InputAction.CallbackContext test) //Input declared in the inspector.
    {
        if (test.started)
        {
            boost();
        }
    }
}
