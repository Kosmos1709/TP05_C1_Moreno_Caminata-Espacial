using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryBotton : MonoBehaviour
{
    [SerializeField] private Button Retry;
    void Start()
    {
        Retry.onClick.AddListener(RestartScene);
    }
    private void OnDestroy()
    {
        Retry.onClick.RemoveAllListeners();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
