using UnityEngine;

public class ballManager : MonoBehaviour
{

    [SerializeField] GameObject Player;

    public void Death()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<playerScript>().Death();
    }
}
