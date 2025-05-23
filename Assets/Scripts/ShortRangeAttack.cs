using UnityEngine;

public class ShortRangeAttack : MonoBehaviour, IAttack
{
    public void Attack()
    {
        Debug.Log("Attacking");
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Attack();
        }
    }
}
