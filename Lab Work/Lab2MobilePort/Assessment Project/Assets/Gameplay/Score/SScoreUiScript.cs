using UnityEngine;
using TMPro;
using System.Threading.Tasks;
using Unity.VisualScripting;

public class ScoreUiScript : MonoBehaviour
{
    public TMP_Text textbox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        updateScoreText(ScoreManager.score);
        ScoreManager.singleton.scoreUpdated.AddListener(updateScoreText);
    }


    public void updateScoreText(int scoreAmount) //Update the text 
    {
        textbox.text = $"Score: {scoreAmount}";
    }
}
