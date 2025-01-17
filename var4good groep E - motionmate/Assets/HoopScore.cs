using UnityEngine;

public class HoopScore : MonoBehaviour
{
    public int score = 0; // Houdt de score bij

    private void OnTriggerEnter(Collider other)
    {
        // Controleer of het object dat de trigger raakt de bal is
        if (other.CompareTag("Ball"))
        {
            score++; // Verhoog de score
            Debug.Log("Score: " + score);
        }
    }
}
