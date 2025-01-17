using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject startButton;       // Reference to the Start button
    public GameObject informationButton; // Reference to the Information button
    public GameObject activityMenu;      // Panel with Activity1 and Activity2
    public GameObject informationPanel;  // The InformationPanel

    public void ShowActivityMenu()
    {
        // Hide the Start button and show the ActivityMenu
        startButton.SetActive(false);
        activityMenu.SetActive(true);
    }

    public void ShowInformationPanel()
    {
        // Hide the Information button and show the InformationPanel
        informationButton.SetActive(false);
        informationPanel.SetActive(true);
    }

    public void HideInformationPanel()
    {
        // Hide the InformationPanel and show the Information button
        informationPanel.SetActive(false);
        informationButton.SetActive(true);
    }
}
