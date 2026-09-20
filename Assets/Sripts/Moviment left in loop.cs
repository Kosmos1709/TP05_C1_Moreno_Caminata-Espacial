using UnityEngine;

public class Movimentleftinloop : MonoBehaviour
{
    [SerializeField] private GameObject Object;
    private Rigidbody2D RB;
    [SerializeField] public float speed = 5;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    
    private void FixedUpdate()
    {
        RB.MovePosition(RB.position + Vector2.left * speed * Time.fixedDeltaTime);
    }
}
