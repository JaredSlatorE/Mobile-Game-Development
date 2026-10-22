using System.Collections.Generic;
using Unity.Profiling;
using Unity.VisualScripting;
using UnityEngine;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Prefab;
    private List<GameObject> List = new List<GameObject>();
    //https://docs.unity3d.com/6000.6/Documentation/ScriptReference/Unity.Profiling.ProfilerMarker.html
    private static readonly ProfilerMarker s_SpawnTechPerformanceMarker = new ProfilerMarker("SpawnTech.Spawn");

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("You're so dead");
        s_SpawnTechPerformanceMarker.Begin();
    }

    // Update is called once per frame
    void Update()
    {
        using (s_SpawnTechPerformanceMarker.Auto()) //https://www.youtube.com/watch?v=DsrFkPP0Qe8
        {
             for (int i = 0; i < 200; i++ )
            {
                float RandomX =  Random.Range(-9,9), RandomY =  2, RandomZ = 0;
                Instantiate(Prefab).transform.position = new Vector3(RandomX,RandomY,RandomZ);
            }
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
