using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Prefab;
    private List<GameObject> List = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("You're so dead");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 200; i++ )
        {
            float RandomX =  Random.Range(-9,9), RandomY =  2, RandomZ = 0;
            Instantiate(Prefab).transform.position = new Vector3(RandomX,RandomY,RandomZ);
        }

  
        // List.Add(instance);
        // if(List.Count < 100)
        // {
        //     Debug.Log("Cleared");
        //     for (int i = 0;i <= List.Count;)
        //     {
        //         Debug.Log(List[i]);
        //         Destroy(List[i]);
        //     }
        // }

        return;
        
    }
}
