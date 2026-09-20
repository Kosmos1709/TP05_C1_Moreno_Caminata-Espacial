using UnityEngine;

public class PowerUpDestroyContact : MonoBehaviour
{
    private Rigidbody2D RB;
    [SerializeField] private GameObject PowerUp;


    
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();


    }


    public void OnTriggerEnter2D (Collider2D collision)
    {
       if (collision.CompareTag("Player"))
        {
            Debug.Log("PowerUp recogido");

            Destroy(gameObject);
        }
    }

}
