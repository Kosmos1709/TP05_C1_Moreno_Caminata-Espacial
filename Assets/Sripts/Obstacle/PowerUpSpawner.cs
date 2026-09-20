using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] private GameObject PowerUp;
    private float PositionRAndomX;
    private float PositionRAndomy;
    public float CDPoweUp = 5f;
    private float Timer;

 

    void Update()
    {
        PositionRAndomX = Random.Range(12, 30);
        PositionRAndomy = Random.Range(1, -3);
        Vector2 Position = new Vector2(PositionRAndomX, PositionRAndomy);

        Timer += Time.deltaTime;
        if (Timer >= CDPoweUp)
        {
            Instantiate(PowerUp, Position, Quaternion.identity);
            Timer = 0f;
        }
    }
}
