using UnityEngine;


public class LegitRGBScript : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
        float ColorR = Random.Range(0,100), ColorG = Random.Range(0,100), ColorB = Random.Range(0,100);
        spriteRenderer.color = new Color(ColorR,ColorG,ColorB);

    }
}
