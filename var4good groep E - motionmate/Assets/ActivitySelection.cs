using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivitySelection : MonoBehaviour
{
    // Method to load Activity 1
    public void LoadActivity1()
    {
        SceneManager.LoadScene("Activity1Scene");
    }

    // Method to load Activity 2
    public void LoadActivity2()
    {
        SceneManager.LoadScene("Activity2Scene");
    }

    // Method to load Activity 3
    public void LoadActivity3()
    {
        SceneManager.LoadScene("Activity3Scene");
    }
    public void LoadInformation()
    {
    SceneManager.LoadScene("InformationScene");
    }

}
