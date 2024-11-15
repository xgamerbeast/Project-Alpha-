using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;  // Assign your Game Over panel here in the Inspector

    private bool isGameOver = false;

    void Start()
    {
        gameOverPanel.SetActive(false);  // Ensure the panel is hidden at the start
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;
        gameOverPanel.SetActive(true);  // Show the Game Over panel
        Time.timeScale = 0f;  // Pause the game
    }

    public void ReplayGame()
    {
        Time.timeScale = 1f;  // Resume the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Reloads the current scene
    }

    public void ExitGame()
    {
        Application.Quit();  // Quits the application
        Debug.Log("Game is exiting");  // This log will show in the editor, but not in the built game
    }
}
