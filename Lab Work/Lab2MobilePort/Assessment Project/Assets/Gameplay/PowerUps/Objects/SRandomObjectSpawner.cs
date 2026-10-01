using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

[System.Serializable]
public struct randomSpawnObject
{
    public GameObject Object;
    public int amount;
}
public class SRandomObjectSpawner : MonoBehaviour
{
    public Vector2 bottomLeftArea;
    public Vector2 topRightArea;

    public GameObject container;


    [SerializeField]
    public randomSpawnObject [] objects; 

    void Start()
    {
        if (DataManager.seed != 0)
        {
            Random.InitState(DataManager.seed); //Sets the seed of the game to that of the value of the data manager
        }
        spawnObjectsRandomly(objects);
    }

    public void spawnObjectsRandomly(randomSpawnObject[] objects) //Spawns objects randomly from a list of gameobjects and damounts
    {
        for(int i = 0; i < objects.Length; i++) //Start at 0 due to arrays starting at 0
        {
            spawnObjects(objects[i].Object,objects[i].amount);
        }
    }

    public void spawnObjects(GameObject objectType, int amount) //Spawns the amount of the object type is inputted and puts is parent as the container
    {
        for(int i = 1; i < amount + 1; i++)
        {
            GameObject newObject = Instantiate(objectType,container.transform);
            newObject.transform.position = calculateRandomPosition(bottomLeftArea,topRightArea);
        }
    }

    public Vector2 calculateRandomPosition(Vector2 bottomLeftArea, Vector2 topRightArea)
    {
        return new Vector2(Random.Range(bottomLeftArea.x,topRightArea.x),Random.Range(bottomLeftArea.y,topRightArea.y));
    }
}
