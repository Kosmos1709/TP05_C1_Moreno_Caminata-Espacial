using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMixMainMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer audiomixer;


    [SerializeField] private Slider VMaster;
    [SerializeField] private Slider VBackground;
    [SerializeField] private Slider VSfx;
    [SerializeField] private Slider VUi;


    private void Awake()
    {
        VMaster.onValueChanged.AddListener(SliderMaster);
        VBackground.onValueChanged.AddListener(SliderBackground);
        VSfx.onValueChanged.AddListener(SliderSFX);
        VUi.onValueChanged.AddListener(SliderUI);
    }


    private void OnDestroy()
    {
     
        VMaster.onValueChanged.RemoveAllListeners();
        VBackground.onValueChanged.RemoveAllListeners();
        VSfx.onValueChanged.RemoveAllListeners();
        VUi.onValueChanged.RemoveAllListeners();
    }
    void Start()
    {
        
    }

  

    /// ///////////////////////////////
    private void SliderMaster( float value)
    {
        audiomixer.SetFloat("VolumeMaster", value);

    }
    private void SliderBackground(float value)
    {
        audiomixer.SetFloat("VolumeBackground", value);

    }
    private void SliderSFX(float value)
    {
        audiomixer.SetFloat("VolumeSFX", value);

    }
    private void SliderUI(float value)
    {
        audiomixer.SetFloat("VolumeUI", value);

    }








    void Update()
    {
        
    }
}
