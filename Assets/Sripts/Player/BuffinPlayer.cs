using UnityEngine;

public class BuffinPlayer : MonoBehaviour
{
    [Header ("Extralife")]
    public int ExLife = 0;
    public Vector2 RespawnPosition;

    [Header("SlowMotion")]
    public bool activeBuffSlow;
    public float countDown;

    void Start()
    {
        RespawnPosition = transform.position;
    }
    public void ActivateBuff()
    {
        activeBuffSlow = true;
        countDown = 5f;
        Time.timeScale = 0.5f;
    }

    void Update()
    {
        if (activeBuffSlow)
        {
            countDown -= Time.deltaTime;

            if (countDown <= 0)
            {
                Time.timeScale = 1f;
                activeBuffSlow = false;
            }
        }
    }

    //////ADD life////////
    public void AddLife()
    {
        ExLife++;
    }
    public void DIE()
    {
        if (ExLife > 0)
        {
            ExLife--;

            // Reinicia posición
            transform.position = RespawnPosition;

            // Detiene velocidad
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.linearVelocity = Vector2.zero;

            // Aquí puedes reiniciar objetos del mundo
        }
        else
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }
}
