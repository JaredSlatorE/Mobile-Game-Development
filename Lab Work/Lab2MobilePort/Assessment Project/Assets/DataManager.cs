
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    public static int seed = 1; //Game Seed


    public static int totalScore;

    public static DataManager singleton;
    void Awake()
    {
        singleton = this;
    }
}
