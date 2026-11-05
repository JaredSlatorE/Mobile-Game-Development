using Player.Save;
using Player.Save.Data;
using UnityEngine;

public class TestDataCreating : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerSaveData data = PlayerSaveService.GetDataInstance();
        data.Coins += 5;
        Debug.Log(data.Coins);
        PlayerSaveService.UpdateData(data);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
