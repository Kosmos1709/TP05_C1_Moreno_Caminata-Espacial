using UnityEngine;

public class BuffinPlayer : MonoBehaviour
{
    [Header("Panel End game")]
    [SerializeField] private GameObject PanelScore;

    [Header ("Extralife")]
    public int ExLife ;
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
        countDown = 2.5f;
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
        if (!PanelScore.activeSelf)
        {
            Time.timeScale = 1;
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
            PanelScore.SetActive(!PanelScore.activeSelf);
            
        }
    }
    
    
    
}
