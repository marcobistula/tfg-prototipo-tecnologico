using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public GameObject saveLoadWindow;

    public GameObject carbohydratesWindow;
    public GameObject proteinsWindow;
    public GameObject fatsWindow;
    public GameObject micronutrientsWindow;

    public GameObject missionCompletedWindow;

    // Start Button
    public void StartGame()
    {
        SceneManager.LoadScene("MainGameScene");
    }
    
    // Play Again button
    public void RestartGame()
        {
            SceneManager.LoadScene("MainGameScene");
        }

    // Exit button
    public void ExitGame()
        {
            Application.Quit();
        }

    // Close Buttons
    public void CloseSaveWindow()
    {
        saveLoadWindow.gameObject.SetActive(false);
    }

    public void CloseCarbohydratesWindow()
    {
        carbohydratesWindow.gameObject.SetActive(false);
    }

    public void CloseProteinsWindow()
    {
        proteinsWindow.gameObject.SetActive(false);
    }

    public void CloseFatsWindow()
    {
        fatsWindow.gameObject.SetActive(false);
    }

    public void CloseMicronutrientsWindow()
    {
        micronutrientsWindow.gameObject.SetActive(false);
        missionCompletedWindow.gameObject.SetActive(true);
    }

    // Desactivates Save/Load and advice windows
    public void Start()
    {
        saveLoadWindow.gameObject.SetActive(false);

        carbohydratesWindow.gameObject.SetActive(false);
        proteinsWindow.gameObject.SetActive(false);
        fatsWindow.gameObject.SetActive(false);
        micronutrientsWindow.gameObject.SetActive(false);
        missionCompletedWindow.gameObject.SetActive(false);

    }
    
    // Exit the game with escape key
    public void Update() { 

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (Input.GetKey("p"))
        {
            saveLoadWindow.gameObject.SetActive(true);
        }

       
    }


}
