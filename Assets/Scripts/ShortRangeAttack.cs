using UnityEngine;

public class ShortRangeAttack : BaseAttack
{
    // Updates the player's health
    public override void Attack()
    {
        CurrentEntity.Damaged(AttackAmount);
    }

    // While the colliders for the player and the enemy are overlapping, the attack function is run
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Attack();
        }
    }
}
