
using UnityEngine;
using UnityEngine.InputSystem;

public class SPusherFlingScript : MonoBehaviour
{
    public Animator flingAnimation;

    public int flingAmount;
    private bool shouldFling;
    private float delayTimer = 0;
    public float delayTimerAmount;
    public bool facingRight;
    public InputAction inputAction;

    private Rigidbody2D collisonComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputAction = InputSystem.actions.FindAction("Push");
        flingAnimation.SetBool("FacingRight", facingRight);
    }
    void Update()
    {
        shouldFling = inputAction.phase.ToString() == "Performed";
        delayTimer -= Time.deltaTime; //Reduces the delay timer, stops the code from mass flinging the ball.
        
        flingAnimation.SetBool("FlingButtonHeld", shouldFling); //Plays the animation if the player hits it
        if (shouldFling && delayTimer < 0) //If the player is pressing the button and the timer is less than zero
        {
            if (collisonComponent)
            {
                collisonComponent.AddForce(new Vector2(gameObject.transform.rotation.z,flingAmount));
                print(collisonComponent.totalForce);
            }
            delayTimer = delayTimerAmount;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        collisonComponent = collision.GetComponent<Rigidbody2D>();
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        collisonComponent = null;
    }
}
