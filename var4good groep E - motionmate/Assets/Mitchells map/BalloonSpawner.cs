using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public GameObject balloonPrefab;   // Het prefab van de ballon
    public Vector3 spawnAreaSize;     // Grootte van de kubus waarin ballonnen spawnen
    public float spawnIntervalMin = 0.2f;  // Minimale tijd tussen het spawnen van ballonnen
    public float spawnIntervalMax = 5f;  // Maximale Tijd tussen het spawnen van ballonnen
    public float balloonSpeed = 2f;   // Zweefsnelheid van de ballonnen
    public float despawnZ = -10f;     // Z-positie waarop de ballonnen verdwijnen

    private void Start()
    {
        // Start het spawnen van ballonnen
        Invoke(nameof(SpawnBalloon), 0f);
    }

    private void SpawnBalloon()
    {
        // Kies een willekeurige positie binnen de kubus
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
            Random.Range(-spawnAreaSize.y / 2, spawnAreaSize.y / 2),
            spawnAreaSize.z / 2 // Altijd aan de voorkant van de kubus
        );

        // Maak een nieuwe ballon op de gekozen positie
        GameObject newBalloon = Instantiate(balloonPrefab, transform.position + randomPosition, Quaternion.identity);

        // Geef de ballon zijn bewegingscomponent
        BalloonMovement movement = newBalloon.AddComponent<BalloonMovement>();
        movement.speed = balloonSpeed;
        movement.despawnZ = despawnZ;

        // Spawn weer een ballon na een willekeurige wachttijd
        float randomTime = Random.Range(spawnIntervalMin, spawnIntervalMax);
        Invoke(nameof(SpawnBalloon), randomTime);
}

