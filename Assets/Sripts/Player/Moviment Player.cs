using System;
using UnityEngine;
using UnityEngine.UI;
public class MovimentPlayer : MonoBehaviour
{
    [Header("Keys")]
    [SerializeField] private KeyCode jump;

    [Header("Components")]
    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private Animator animator;

    [Header("Game Objects")]
    [SerializeField] private GameObject EndWall;
    [SerializeField] private GameObject Floor;

    [Header("Var")]
    [SerializeField] private float speedjump = 10f;
    [SerializeField] private bool CanJump = false;

    BuffinPlayer player;



    void Start()
    {
        RB.GetComponent<Rigidbody2D>();
        player = GetComponent<BuffinPlayer>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == EndWall)
        {
            player.DIE();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            CanJump = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            CanJump = false;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(jump))
        {
            RB.position += Vector2.up * speedjump * Time.fixedDeltaTime;
            if (CanJump==true)
            {
                animator.SetTrigger("JumpPlayer");
            }
        }
        
    }

 
}
