using UnityEngine;

public class ShortRangeAttack : MonoBehaviour, IAttack
{
    [SerializeField] private Entity player;
    [SerializeField] private int attack_amount = 1;
    public void Attack()
    {
        Debug.Log("Player Health: " + player.Health);
        player.Damaged(attack_amount);
        player.CheckIsAlive();
        Debug.Log("New Player Health: " + player.Health);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Attack();
        }
    }
}
