using UnityEngine;

public class Invincible5sec : MonoBehaviour
{
    [SerializeField] public bool ActiveInvicible=false;
    Rigidbody2D RB;
    void Start()
    {
        RB.GetComponent<Rigidbody2D>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("INVINCIBLE");

            ActiveInvicible = true;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
