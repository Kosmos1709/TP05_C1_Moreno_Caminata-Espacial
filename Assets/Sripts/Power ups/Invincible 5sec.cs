using UnityEngine;

public class Invincible5sec : MonoBehaviour
{
    [SerializeField] public bool ActiveInvicible=false;
    [SerializeField] public InvincibleBuffActive buff;
    public Rigidbody2D RB;
    void Start()
    {
        RB=GetComponent<Rigidbody2D>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("INVINCIBLE");
            
                buff.IsTrigger();
        }
    }

    void Update()
    {
        
    }
}
