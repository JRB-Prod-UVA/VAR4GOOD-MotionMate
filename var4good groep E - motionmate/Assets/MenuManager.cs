using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject activityMenu;
    public GameObject informationPanel;

    public void ShowActivityMenu()
    {
        activityMenu.SetActive(true);
    }

    public void ShowInformationPanel()
    {
        informationPanel.SetActive(true);
    }

    public void HideInformationPanel()
    {
        informationPanel.SetActive(false);
    }
}
