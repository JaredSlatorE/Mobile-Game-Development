using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SSeedSetterScript : MonoBehaviour
{
    private Slider slider;
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.onValueChanged.AddListener(setSeed);
    }
    public void setSeed(float value)
    {
        int intvalue = (int)value;
        DataManager.seed = intvalue;
    }
}
