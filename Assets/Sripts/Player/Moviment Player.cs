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



    void Start()
    {
        RB.GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == EndWall)
        {
            Time.timeScale = 0f;
        }
    }
    


    private void FixedUpdate()
    {

        if (Input.GetKey(jump))
        {
            
            RB.position += Vector2.up * speedjump * Time.fixedDeltaTime;

        }
        
    }



    void Update()
    {

    }
}
