using UnityEngine;

public class LaserOgen : MonoBehaviour
{
    public LineRenderer laserRenderer;  // Reference to the LineRenderer
    public Transform eyeOrigin;        // The origin of the laser
    public float laserLength = 10f;    // Maximum laser distance
    public LayerMask balloonLayer;     // Layer for target objects

    public AudioSource audioSource;    // AudioSource reference to play the sound
    public AudioClip popSound;         // Single pop sound clip

    public float minPitch = 0.8f;      // Minimum pitch value
    public float maxPitch = 1.2f;      // Maximum pitch value

    void Update()
    {
        // Define laser start and end points
        Vector3 startPoint = eyeOrigin.position;
        Vector3 endPoint = startPoint + eyeOrigin.forward * laserLength;

        // Check for collisions
        if (Physics.Raycast(startPoint, eyeOrigin.forward, out RaycastHit hit, laserLength, balloonLayer))
        {
            endPoint = hit.point; // Adjust endpoint to the hit point

            // Check if the balloon has already been processed
            Balloon balloon = hit.collider.GetComponent<Balloon>();
            if (balloon != null && !balloon.isPopped)
            {
                balloon.isPopped = true; // Mark the balloon as popped
                PlayRandomPitchSound();
                Destroy(balloon.gameObject, 0.2f); // Delay the destruction slightly
            }
        }

        // Update the LineRenderer positions
        laserRenderer.SetPosition(0, startPoint); // Start of the laser
        laserRenderer.SetPosition(1, endPoint);  // End of the laser
    }

    // Method to play the sound with a random pitch
    private void PlayRandomPitchSound()
    {
        // Set a random pitch value
        audioSource.pitch = Random.Range(minPitch, maxPitch);

        // Play the sound
        audioSource.PlayOneShot(popSound);
    }
}