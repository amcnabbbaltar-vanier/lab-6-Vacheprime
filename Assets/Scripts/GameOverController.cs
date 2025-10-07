using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public GameObject GameOverPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameOverPanel.SetActive(true);
        if (GameManager.Instance)
        {
            ScoreText.text = "Score: " + GameManager.Instance.score.ToString();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
