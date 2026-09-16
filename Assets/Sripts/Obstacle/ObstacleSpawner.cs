using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    private float PositionRAndomX;
    private float PositionRAndomy;
    private float CDEnemy=1f;
    private float Timer;
    //Instantiate(objeto, posicion, rotacion);
    void Start()
    {
        
    }

    // Update is called once per frame
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
