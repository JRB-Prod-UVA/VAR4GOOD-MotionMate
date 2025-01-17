using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadBasicScene()
    {
        SceneManager.LoadScene("BasicScene");
    }
}
