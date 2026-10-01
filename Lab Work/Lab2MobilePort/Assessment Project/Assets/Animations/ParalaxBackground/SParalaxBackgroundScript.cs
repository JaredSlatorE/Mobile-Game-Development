using UnityEngine;
using UnityEngine.Rendering;

public enum ParalaxType
{
    follow,
}
public class ParalaxBackgroundScript : MonoBehaviour
{
    public GameObject relativeObject;
    public float movementMultiplier;
    public ParalaxType Type;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = gameObject.transform.position;
    }
    void Update()
    {
        switch(Type)
        {
            case ParalaxType.follow:
                gameObject.transform.position = (startPosition + (relativeObject.transform.position * movementMultiplier));
                break;
        }
    }
}
