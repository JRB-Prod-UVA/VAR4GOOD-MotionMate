using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadBasicScene()
    {
        SceneManager.LoadScene("BasicScene");
    }
    // Method to load the Basketball scene
    public void LoadBasketballScene()
    {
        SceneManager.LoadScene("basketbal");
    }
}
