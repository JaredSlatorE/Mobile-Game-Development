using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

namespace UI.Click {
    public class OpenLevelOnClickScript : MonoBehaviour
    {
        public string SceneName;
        private Button Button;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Button = gameObject.GetComponent<Button>();
            Button.onClick.AddListener(click);
        }

        // Update is called once per frame
        void click()
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
