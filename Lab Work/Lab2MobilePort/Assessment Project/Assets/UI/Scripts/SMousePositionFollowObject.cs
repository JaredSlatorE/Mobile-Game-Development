using Unity.VisualScripting;
using UnityEngine;

public class SMousePositionFollowObject : MonoBehaviour
{
    public Camera camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.mousePosition.x < 1920 && Input.mousePosition.x > 0) && (Input.mousePosition.y < 1080 && Input.mousePosition.y > 0)) //I hate this
        {
            gameObject.transform.position = camera.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
