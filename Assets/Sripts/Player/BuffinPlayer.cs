using UnityEngine;

public class BuffinPlayer : MonoBehaviour
{
    [Header("Invincible")]
    Invincible5sec invicible;
    [SerializeField]private float Secons5 = 5f;
    [SerializeField] private Collider2D Col;

    [Header ("Extralife")]
    public int ExLife ;
    public Vector2 RespawnPosition;

    [Header("SlowMotion")]
    public bool activeBuffSlow;
    public float countDown;

    void Start()
    {
        invicible=GetComponent<Invincible5sec>();
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
        ////// INVINCIBLE ///////
        if (invicible.ActiveInvicible)
        {
            Secons5 -= Time.deltaTime;
            if (Secons5>=0)
            {
                Col.isTrigger = true;
            }
            if (Secons5 <= 0)
            {
                Col.isTrigger = false;
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
            Debug.Log("New LIFE");
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
