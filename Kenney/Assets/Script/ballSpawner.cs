using System.Collections;
using UnityEngine;

public class ballSpawner : MonoBehaviour
{



    private bool canSpawn;

    [Header("Asset to load")]
    public GameObject Ball;

    [Header("Spawn frequency")]
    [Range(0, 50)]
    public float spawnPossibility;

    [Header("Spawn deelay")]
    public int spawnDeelayInSeconds;



    private void Awake()
    {
        canSpawn = false;
        StartCoroutine(spawnDeelay());
    }
    private void Update()
    {
        if (canSpawn)
        {
            canSpawn = false;

            //Cambio di posizione del ballSpawner(gameObject)
            gameObject.transform.position = new Vector2(Random.Range(-16, 29), Random.Range(16, -29));

            Instantiate(Ball, gameObject.transform.position, Quaternion.identity);



            //Inizializza un deelay di spawn
            StartCoroutine(spawnDeelay());
            IEnumerator spawnDeelay()
            {
                yield return new WaitForSeconds(spawnPossibility);
                canSpawn = true;
            }
        }
    }

    IEnumerator spawnDeelay()
    {
        yield return new WaitForSeconds(spawnDeelayInSeconds);
        canSpawn = true;
    }
}