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
        if (collision.CompareTag("Finish"))
        {
            BuffinPlayer player = collision.GetComponent<BuffinPlayer>();

            if (player != null)
            {
                player.AddLife();
            }

            Destroy(gameObject);
        }
    }

    void Update()
    {
       
    }
}
