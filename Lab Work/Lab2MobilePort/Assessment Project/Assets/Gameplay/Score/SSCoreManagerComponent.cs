

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager singleton {get;private set;}
    public UnityEvent<int> scoreUpdated;

    private void Awake()
    {
        singleton = this;
        SceneManager.sceneLoaded += clearScore;
    }

    public static int score {get;private set;}
    public static int scoreMultiplier = 1;
    
    public int addScore(int AddAmount)
    {
        score += AddAmount * scoreMultiplier;
        DataManager.totalScore = score += AddAmount * scoreMultiplier;
        scoreUpdated.Invoke(score);
        return score;
    }

    public void clearScore(Scene scene, LoadSceneMode mode)
    {
        score = 0;
    }
}