using UnityEngine;

public class PoweUpBuff : MonoBehaviour
{
    public Rigidbody2D RB;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Power ACTIVE");

            BuffinPlayer buff = collision.GetComponent<BuffinPlayer>();

            if (buff != null)
            {
                buff.ActivateBuff();
            }
        }
    }

}