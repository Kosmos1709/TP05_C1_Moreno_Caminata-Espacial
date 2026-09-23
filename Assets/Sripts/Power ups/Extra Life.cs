using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            BuffinPlayer player = collision.GetComponent<BuffinPlayer>();

            if (player != null)
            {
                player.AddLife();
            }

                Debug.Log("Extra Life GET");
            Destroy(gameObject);
        }
    }

    void Update()
    {
       
    }
}
