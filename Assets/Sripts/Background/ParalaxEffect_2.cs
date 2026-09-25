using UnityEngine;

public class ParalaxEffect_2 : MonoBehaviour
{
    [Header("Caps")]
    [SerializeField] private GameObject cap;

    [Header("Speed of Caps")]
    [SerializeField] private int speedCap;



    void Update()
    {
        cap.transform.position += Vector3.left * speedCap * Time.deltaTime;

        if (cap.transform.position.x <= -15)
        {
            cap.transform.position += new Vector3(30, 0);
        }
    }
}
