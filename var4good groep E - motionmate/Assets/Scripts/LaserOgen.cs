using UnityEngine;

public class LaserOgen : MonoBehaviour
{
    public LineRenderer laserRenderer;  // Reference to the LineRenderer
    public Transform eyeOrigin;        // The origin of the laser
    public float laserLength = 10f;    // Maximum laser distance
    public LayerMask balloonLayer;     // Layer for target objects

    void Update()
    {
        // Define laser start and end points
        Vector3 startPoint = eyeOrigin.position;
        Vector3 endPoint = startPoint + eyeOrigin.forward * laserLength;

        // Check for collisions
        if (Physics.Raycast(startPoint, eyeOrigin.forward, out RaycastHit hit, laserLength, balloonLayer))
        {
            endPoint = hit.point; // Adjust endpoint to the hit point

            // Destroy the hit object if it matches the layer
            Destroy(hit.collider.gameObject);
        }

        // Update the LineRenderer positions
        laserRenderer.SetPosition(0, startPoint); // Start of the laser
        laserRenderer.SetPosition(1, endPoint);  // End of the laser
    }
}