using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject ballPrefab; // Referentie naar de bal-prefab
    public Transform spawnPoint; // Plaats waar de bal verschijnt

    private GameObject currentBall; // De actieve bal in het spel

    void Start()
    {
        SpawnBall();
    }

    public void SpawnBall()
    {
        // Controleer of er al een bal actief is
        if (currentBall == null)
        {
            // Maak een nieuwe bal aan
            currentBall = Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }

    public void DestroyBall()
    {
        // Vernietig de huidige bal
        if (currentBall != null)
        {
            Destroy(currentBall);
        }
    }
}
