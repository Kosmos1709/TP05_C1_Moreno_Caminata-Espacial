using UnityEngine;

public class BuffinPlayer : MonoBehaviour
{
    [SerializeField] public Movimentleftinloop movimentleft;
    [SerializeField] public PowerUpSpawner powerupspawner;
    [SerializeField] public ObstacleSpawner obstaclespawner;
    public bool activeBuff;
    public float countDown;

    void Start()
    {
        movimentleft = FindFirstObjectByType<Movimentleftinloop>();
        powerupspawner = FindFirstObjectByType<PowerUpSpawner>();
        obstaclespawner = FindFirstObjectByType<ObstacleSpawner>();
    }
    public void ActivateBuff()
    {
        activeBuff = true;
        countDown = 5f;
        Time.timeScale = 0.5f;
    }

    void Update()
    {
        if (activeBuff)
        {
            countDown -= Time.deltaTime;

            if (countDown <= 0)
            {
                Time.timeScale = 1f;
                activeBuff = false;
            }
        }
    }
}
