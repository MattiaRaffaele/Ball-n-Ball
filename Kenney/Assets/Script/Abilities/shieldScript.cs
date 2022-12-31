using UnityEngine;

public class shieldScript : MonoBehaviour
{
    [Header("Animator")]
    [SerializeField] Animator enemyGroupAnimator;

    [Header("Animator triggers")]
    [SerializeField] string endTrigger;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Shield")
        {
            Debug.Log("tumadre");
            enemyGroupAnimator.SetTrigger(endTrigger);
        }
    }
}
