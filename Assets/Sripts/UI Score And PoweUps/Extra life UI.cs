using UnityEngine;
using TMPro;
public class ExtralifeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextExtraLife;
    [SerializeField] BuffinPlayer buffinplayerscript;
    private int extralifes;
    void Start()
    {
        extralifes = 0;
    }

    void Update()
    {
        extralifes = buffinplayerscript.ExLife;
        TextExtraLife.text = string.Format("{0}", extralifes);
    }
}
