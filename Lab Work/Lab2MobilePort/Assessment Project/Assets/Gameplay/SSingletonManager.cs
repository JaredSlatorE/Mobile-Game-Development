using UnityEngine;
using UnityEngine.SceneManagement;

public class SSingeltonManager : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += onSceneChange;
    }

    private void onSceneChange(Scene scene, LoadSceneMode mode)
    {
        SSingeltonManager[] duplicate = FindObjectsByType<SSingeltonManager>(FindObjectsSortMode.None);

        for (int i = 0; i < duplicate.Length; i++)
        {
            if (duplicate[i] != this)
            {
                Destroy(duplicate[i].gameObject);
            }
        }
    }
}
