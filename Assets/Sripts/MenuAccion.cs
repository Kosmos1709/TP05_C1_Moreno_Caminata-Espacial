using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuAccion : MonoBehaviour
{

    [SerializeField] private Button BtnStart;
    [SerializeField] private Button BtnVolume;
    [SerializeField] private Button BtnCredits;

    [SerializeField] private GameObject PanelVolume;
    [SerializeField] private GameObject PanelCredits;



    private void Awake()
    {
        BtnStart.onClick.AddListener(OnButtonStartClick);
        BtnVolume.onClick.AddListener(OnButtonVolumeClick);
        BtnCredits.onClick.AddListener(OnButtonCreditsClick);


    }
    private void OnDestroy()
    {
        BtnStart.onClick.RemoveAllListeners();
        BtnVolume.onClick.RemoveAllListeners();
        BtnCredits.onClick.RemoveAllListeners();


    }


    private void OnButtonStartClick()
    {
        SceneManager.LoadScene("Gameplay");
    }
    private void OnButtonVolumeClick()
    {
        PanelVolume.SetActive(!PanelVolume.activeSelf);
    }
    private void OnButtonCreditsClick()
    {
        PanelCredits.SetActive(!PanelCredits.activeSelf);

    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
