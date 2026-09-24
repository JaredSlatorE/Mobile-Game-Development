using TMPro;
using UnityEngine;

public class MobileGUI : MonoBehaviour
{
    private float StandardFPS = 1f/30f;
    private int CurrentFrames = 0;
    public int FPS = 0;
    private float TimePassed = 0;

    public TMP_Text FPSText;
    public TMP_Text DeviceText;
    public TMP_Text ResolutionText;

    public TMP_Text GPUText;
    public TMP_Text MemoryText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DeviceText.text = $"Device: {SystemInfo.deviceModel}, OS: {SystemInfo.operatingSystem}";
        ResolutionText.text = $"Resolution: {Screen.currentResolution}, RefreshRate: {Screen.currentResolution.refreshRateRatio}, DPI: {Screen.dpi}";
        GPUText.text = $"GPU : {SystemInfo.graphicsDeviceName}, GraphicsMemory: {SystemInfo.graphicsMemorySize}";
        MemoryText.text = $"Memory: {SystemInfo.systemMemorySize}";
    }

    // Update is called once per frame
    void Update()
    {
        TimePassed += Time.deltaTime;
        if (TimePassed >= 1)
        {
            TimePassed = 0;
            FPSText.text = $"FPS: {FPS}";
        }
        StandardFPS += (Time.unscaledDeltaTime - StandardFPS) * 0.1f;
        FPS = (int)(1/StandardFPS);
        CurrentFrames += 1;
    }
}
