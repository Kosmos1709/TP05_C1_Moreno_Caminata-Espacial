using UnityEngine;

public class Movimentleftinloop : MonoBehaviour
{
    [SerializeField] private GameObject Object;
    private Rigidbody2D RB;
    [SerializeField] private int speed = 5;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        RB.MovePosition(RB.position + Vector2.left * speed * Time.fixedDeltaTime);
    }
}
