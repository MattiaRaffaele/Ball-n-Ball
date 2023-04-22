using UnityEngine;

//script made for enemy to manage the collision with the shield

public class shieldScript : MonoBehaviour
{
    [Header("Animator")]
    [SerializeField] Animator enemyGroupAnimator;

    [Header("Animator triggers")]
    [SerializeField] string endTrigger;

    private bool canExecute;

    private void Awake()
    {
        canExecute = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shield" && canExecute)
        {
            canExecute = false;
            enemyGroupAnimator.SetTrigger(endTrigger);
        }
    }
}
