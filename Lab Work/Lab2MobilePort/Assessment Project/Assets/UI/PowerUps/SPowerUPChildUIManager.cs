using UnityEngine;
using UnityEngine.UI;

public class PowerUPChildUIManager : MonoBehaviour
{
    public float duration;
    public Slider slider;
    private float elapsedTime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= duration) //Kill it
        {
            Destroy(gameObject);
        }
        else
        {
            slider.value = elapsedTime/duration; //Change slider duration
        }
    }
}
