using UnityEngine;
using UnityEngine.UI;

public class PauseAcction : MonoBehaviour
{
    [SerializeField] private float Timescale = 1f;

    [SerializeField] private Button BtnContinue;
    [SerializeField] private Button BtnVolume;
    [SerializeField] private Button BtnCredits;

    [SerializeField] private GameObject PanelVolume;
    [SerializeField] private GameObject PanelCredits;

    [SerializeField] private KeyCode EscBtn = KeyCode.Escape;
    [SerializeField] private GameObject PauseMenu;



    private void Awake()
    {
        BtnContinue.onClick.AddListener(OnButtonContinueClick);
        BtnVolume.onClick.AddListener(OnButtonVolumeClick);
        BtnCredits.onClick.AddListener(OnButtonCreditsClick);

        Time.timeScale = Timescale;
    }
    private void OnDestroy()
    {
        BtnContinue.onClick.RemoveAllListeners();
        BtnVolume.onClick.RemoveAllListeners();
        BtnCredits.onClick.RemoveAllListeners();


    }
    void Update()
    {
        if (Input.GetKeyDown(EscBtn))
        {
            PauseMenu.SetActive(!PauseMenu.activeSelf);
        }
            if (PauseMenu.activeSelf)
            {
                Timescale = 0f;
            }
            if (!PauseMenu.activeSelf)
            {
                Timescale = 1f;
            }
    }


    private void OnButtonContinueClick()
    {
        Timescale = 1f;
        PanelVolume.SetActive(false);
        PanelCredits.SetActive(false);
        PauseMenu.SetActive(false);

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

}
