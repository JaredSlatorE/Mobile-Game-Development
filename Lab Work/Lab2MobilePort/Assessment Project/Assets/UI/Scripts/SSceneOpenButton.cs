using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SOpenSceneButton : MonoBehaviour
{
    public string newScene;
    public Button Button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button.onClick.AddListener(onButtonPressed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onButtonPressed()
    {
        //Thanks to Gatsbys "How to load scenes in Unity" tutorial on YouTube
        SceneManager.LoadScene(newScene);
    }
}