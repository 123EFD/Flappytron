using UnityEngine;

public class GameShortcuts : MonoBehaviour
{
    void Update()
    {
        // Pause game when P is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }

        // Quit game when Escape is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    void TogglePause()
    {
        // Toggle pause state
        if (Time.timeScale > 0)
        {
            Time.timeScale = 0;  // Pause the game
            Debug.Log("Game Paused");
            // You might also want to show a pause menu here
        }
        else
        {
            Time.timeScale = 1;  // Resume the game
            Debug.Log("Game Resumed");
            // You might want to hide the pause menu here
        }
    }

    void QuitGame()
    {
        Debug.Log("Quitting game...");
        
        #if UNITY_EDITOR
        // If running in the editor
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // If running in a build
        Application.Quit();
        #endif
    }
}