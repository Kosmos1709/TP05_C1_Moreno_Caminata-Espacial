using UnityEngine;

public class loopFloor : MonoBehaviour
{
    [SerializeField] private GameObject Floor;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x <= -19f)
        {
            Floor.transform.position = new Vector2(36, -5);

        }
    }
}
