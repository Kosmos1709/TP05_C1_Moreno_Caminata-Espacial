using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Floor;
    void Start()
    {
        
    }

    public void SpawnFloor()
    {
        Vector2 Position = new Vector2(19, -5);
        Instantiate(Floor, Position, Quaternion.identity);
    }
    void Update()
    {
        
    }
}
