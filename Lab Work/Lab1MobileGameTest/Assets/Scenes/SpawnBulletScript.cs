using System;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBulletScript : MonoBehaviour
{
    [SerializeField]public GameObject spawnObject;
    [SerializeField]public Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(testFunction);
    }

    public void testFunction()
    {
        Instantiate(spawnObject);
    }
}
