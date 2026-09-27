using UnityEngine;

public class PlayerMenuHTPMoviment : MonoBehaviour
{

    [Header("Keys")]
    [SerializeField] private KeyCode jump;

    [Header("Components")]
    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private Animator animator;

    [Header("Game Objects")]
    [SerializeField] private GameObject Floor;

    [Header("Var")]
    [SerializeField] private float speedjump = 10f;
    [SerializeField] private bool touchFloor = false;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(jump))
        {
            touchFloor = false;
            animator.SetBool("InFloor", touchFloor);
        }
        if (Input.GetKeyUp(jump))
        {
            touchFloor = true;
            animator.SetBool("InFloor", touchFloor);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(jump))
        {
            RB.position += Vector2.up * speedjump * Time.fixedDeltaTime;
        }

    }
}
