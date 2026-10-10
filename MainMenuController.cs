using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [Header("Panels")]
    public GameObject mainPanel;
    public GameObject levelSelectPanel;

    // Shows Level Select and hides Main Menu buttons
    public void OpenLevelSelect()
    {
        mainPanel.SetActive(false);
        levelSelectPanel.SetActive(true);
    }

    // Hides Level Select and restores Main Menu buttons
    public void CloseLevelSelect()
    {
        mainPanel.SetActive(true);
        levelSelectPanel.SetActive(false);
    }

    // Loads a level scene by its string name
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}