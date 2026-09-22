using System;
using UnityEngine;
using UnityEngine.UI;
public class MovimentPlayer : MonoBehaviour
{
    [SerializeField] private KeyCode jump;
    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private GameObject EndWall;
    [SerializeField] private GameObject Floor;
    [SerializeField] private float speedjump = 10f;
    BuffinPlayer player;



    void Start()
    {
        RB.GetComponent<Rigidbody2D>();
        player=GetComponent<BuffinPlayer>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == EndWall)
        {
            player.DIE();
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
