using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    public float speed = 2f;  // Zweefsnelheid van de ballon
    public float despawnZ = -10f; // Z-positie waarop de ballon verdwijnt

    private void Update()
    {
        // Beweeg de ballon langs de Z-as
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // Controleer of de ballon Z = -10 heeft bereikt
        if (transform.position.z <= despawnZ)
        {
            Destroy(gameObject); // Verwijder de ballon
        }
    }
}