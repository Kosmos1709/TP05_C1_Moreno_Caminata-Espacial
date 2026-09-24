using TMPro;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class InvicibleUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextInvincibleUI;
    [SerializeField] InvincibleBuffActive ClokerInvincible;
    public float timer ;
    void Start()
    {

    }

    void Update()
    {

        timer = ClokerInvincible.Secons5;

        int seconds = Mathf.FloorToInt(timer);
        int centesimas = Mathf.FloorToInt((timer - seconds) * 100);

        TextInvincibleUI.text = string.Format("{0:0}:{1:00}", seconds, centesimas);
    }
}
