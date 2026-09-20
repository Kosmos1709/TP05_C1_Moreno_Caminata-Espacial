using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    private float PositionRAndomX;
    private float PositionRAndomy;
    public float CDEnemy=1f;
    private float Timer;
    
    void Update()
    {
        PositionRAndomX= Random.Range(12,30);
        PositionRAndomy = Random.Range(-1, -5);
        Vector2 Position = new Vector2(PositionRAndomX, PositionRAndomy);

        Timer += Time.deltaTime;
        if (Timer>=CDEnemy)
        {
            Instantiate(Enemy, Position, Quaternion.identity);
            Timer = 0f;
        }
    }
}
