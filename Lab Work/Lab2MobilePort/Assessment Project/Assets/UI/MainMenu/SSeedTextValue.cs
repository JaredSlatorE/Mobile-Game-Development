using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SSeedTextValue : MonoBehaviour
{
    public Slider slider;
    TMP_Text text;

    void Start()
    {
        slider.onValueChanged.AddListener(seedText);
        text = gameObject.GetComponent<TMP_Text>();
    }

    public void seedText(float value)
    {
        int newValue = (int)value;
        text.text = $"Seed: {newValue}";
    }
}
