using UnityEngine;

public class DespawnZone : MonoBehaviour
{
    public BallSpawner spawner; // Verwijzing naar het BallSpawner-script

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Je kunt hier eventuele initiële configuraties plaatsen, als nodig
    }

    // Update is called once per frame
    void Update()
    {
        // Hier kun je code plaatsen die elke frame moet worden uitgevoerd, indien nodig
    }

    // Detecteert wanneer een object de triggerzone binnengaat
    private void OnTriggerEnter(Collider other)
    {
        // Controleer of het object dat de trigger raakt de bal is
        if (other.CompareTag("Ball"))
        {
            spawner.DestroyBall(); // Vernietig de bal
            spawner.SpawnBall();  // Spawn een nieuwe bal
        }
    }
}
