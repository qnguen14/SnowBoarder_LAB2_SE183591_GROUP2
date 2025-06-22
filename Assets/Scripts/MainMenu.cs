using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public GameObject howToPlayPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        // Load the game scene (assuming it's named "GameScene")
        SceneManager.LoadSceneAsync(0);
    }

    public void Open()
    {
        if (howToPlayPanel != null)
        {
            howToPlayPanel.SetActive(true);
        }
        else
        {
            Debug.LogWarning("HowToPlayPanel is not assigned in the inspector.");
        }
    }

    public void Close()
    {
        if (howToPlayPanel != null)
        {
            howToPlayPanel.SetActive(false);
        }
        else
        {
            Debug.LogWarning("HowToPlayPanel is not assigned in the inspector.");
        }
    }

    public void Quit()
    {
        // Quit the application
        Debug.Log("Quitting the game...");
        Application.Quit();
    }
}
