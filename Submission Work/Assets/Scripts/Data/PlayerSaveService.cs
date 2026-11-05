
using System.IO;
using Player.Save.Data;
using Unity.VisualScripting;
using UnityEngine;

namespace Player.Save
{
    
    public static class PlayerSaveService
    {
        public static PlayerSaveData GetDataInstance()
        {
            if (File.Exists("SaveData"))
            {
                Debug.Log(File.ReadAllText("SaveData"));
                return JsonUtility.FromJson<PlayerSaveData>(File.ReadAllText("SaveData"));
                
            }
            else
            {
                Debug.Log("Creating new");
                PlayerSaveData data = new PlayerSaveData();
                File.WriteAllText("SaveData",JsonUtility.ToJson(data,true));
                return data;
            }
        }   
    

        public static bool UpdateData(PlayerSaveData data)
        {
            File.WriteAllText("SaveData",JsonUtility.ToJson(data));
            return true;       
        }
    }

}