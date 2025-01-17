using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject startButton;       // Reference to the Start button
    public GameObject informationButton; // Reference to the Information button
    public GameObject activityMenuPanel; // Panel with Activity1 and Activity2
    public GameObject informationPanel;  // The InformationPanel
    public GameObject mainMenuPanel;     // Panel with START and INFORMATION

    // Show the main menu panel and hide the activity menu panel
    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        activityMenuPanel.SetActive(false);
        informationPanel.SetActive(false);
    }

    // Show the activity menu panel and hide the main menu panel
    public void ShowActivityMenu()
    {   
        Debug.Log("ShowActivityMenu called");
        mainMenuPanel.SetActive(false);
        activityMenuPanel.SetActive(true);
    }

    // Show the information panel and hide the main menu panel
    public void ShowInformationPanel()
    {
        mainMenuPanel.SetActive(false);
        informationPanel.SetActive(true);
    }

    // Hide the information panel and return to the main menu
    public void HideInformationPanel()
    {
        informationPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
