using UnityEngine;
using TMPro;
public class Clocker : MonoBehaviour
{
    [SerializeField] private float Clock;
    [SerializeField] TextMeshProUGUI Chronometerro;


    void Start()
    {
        
    }

    void Update()
    {
        /// luego reemplazar con vidas en ves de timescale "cuando me quede sin vidas esto se detendra"
        if (Time.timeScale > 0)
        {
            Clock += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Clock / 60);
            int seconds = Mathf.FloorToInt(Clock % 60);

            // Muestra el texto formateado (ej. 01:05)
            Chronometerro.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
