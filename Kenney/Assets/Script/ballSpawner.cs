using System.Collections;
using UnityEngine;

public class ballSpawner : MonoBehaviour
{



    bool canSpawn = true;

    public GameObject Ball;

    [Range(0, 50)]
    public float spawnPossibility;


    private void Update()
    {
        if (canSpawn)
        {
            canSpawn = false;

            //Cambio di posizione del ballSpawner(gameObject)
            gameObject.transform.position = new Vector2(Random.Range(-25, 25), Random.Range(-25, 25));

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
}