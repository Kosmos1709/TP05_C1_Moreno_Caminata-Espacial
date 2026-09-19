using UnityEngine;

public class TimeScaleGlobal : MonoBehaviour
{
    [SerializeField] private float Timescale;
    [SerializeField] private GameObject PauseMenu;


    private void Awake()
    {
    }
    

    void Update()
    {
        Time.timeScale= Timescale;

        if (PauseMenu.activeSelf)
        {
            Timescale = 0f;
        }
        if (!PauseMenu.activeSelf)
        {
            Timescale = 1f;
        }
    }
}
