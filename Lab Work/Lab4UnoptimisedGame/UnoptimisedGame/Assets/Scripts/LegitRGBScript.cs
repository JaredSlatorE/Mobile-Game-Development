using UnityEngine;
using Unity.Profiling;

public class LegitRGBScript : MonoBehaviour
{
    private static readonly ProfilerMarker s_SpawnTechPerformanceMarker = new ProfilerMarker("RGB.Tick");

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        using (s_SpawnTechPerformanceMarker.Auto())
        {
            SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
            float ColorR = Random.Range(0,100), ColorG = Random.Range(0,100), ColorB = Random.Range(0,100);
            spriteRenderer.color = new Color(ColorR,ColorG,ColorB); 
        }

    }
}
