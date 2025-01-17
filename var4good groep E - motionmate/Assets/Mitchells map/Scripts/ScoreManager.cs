using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;  // Singleton instance
    public TextMeshPro scoreText;         // Text component to display the score
    private int score = 0;                // The current score

    private void Awake()
    {
        // Singleton pattern: ensure only one instance of ScoreManager exists
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Method to increment the score
    public void IncrementScore()
    {
        score++; // Increase the score
        scoreText.text = "Score: " + score; // Update the displayed score
        Debug.Log($"Score updated: {score}");
    }
}