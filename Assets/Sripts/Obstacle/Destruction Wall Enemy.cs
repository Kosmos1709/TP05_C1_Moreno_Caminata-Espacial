using UnityEngine;

public class DestructionWallEnemy : MonoBehaviour
{
    [SerializeField] private GameObject Object;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -9f)
        {
            Destroy(Object);

        }
    }

}
