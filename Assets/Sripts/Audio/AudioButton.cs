using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
    [SerializeField] private Button Btn;
    private AudioSource ClickSound;



    private void Awake()
    {
        ClickSound = GetComponent<AudioSource>();
        Btn.onClick.AddListener(OnButtonStartClick);
    }

    private void OnDestroy()
    {
        Btn.onClick.RemoveAllListeners();
    }

    private void OnButtonStartClick()
    {
        ClickSound.Play();
    }
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
