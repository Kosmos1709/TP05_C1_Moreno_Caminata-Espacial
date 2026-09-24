using UnityEngine;

public class InvincibleBuffActive : MonoBehaviour
{
    [Header("Invincible")]
    [SerializeField] public float Secons5 = 5f;
    [SerializeField] private Collider2D Col;
    [SerializeField] private SpriteRenderer sr;

    void Start()
    {
        sr.GetComponent<SpriteRenderer>();
    }

    public void IsTrigger()
    {
        Col.isTrigger = true;
    }

    void Update()
    {
        //Test//
     
        //Test//

        if (Col.isTrigger)
        {
            Secons5 -= Time.deltaTime;
            sr.color = Color.red;
            if (Secons5 <= 0)
            {
                Col.isTrigger = false;
            }
        }
        if (!Col.isTrigger)
        {
            sr.color = Color.white;
            Secons5 = 5f;
        }
    }
}
