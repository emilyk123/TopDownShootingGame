using UnityEngine;

public class ShortRangeAttack : MonoBehaviour, IAttack
{
    [SerializeField] private Entity _player;
    [SerializeField] private int _attack_amount = 1;
    public Entity CurrentEntity{ get; set; }
    public int AttackAmount
    {
        get
        {
            return _attack_amount;
        }
        set
        {
            // Makes sure attack amount is above zero or prints out that it needs to be above zero
            if (value > 0)
            {
                _attack_amount = value;
            }
            else
            {
                Debug.Log("Attack amount needs to be greater than 0");
            }
        }
    }

    // Updates the player's health
    public void Attack()
    {
        Debug.Log("Player Health: " + CurrentEntity.Health);
        CurrentEntity.Damaged(AttackAmount);
        Debug.Log("New Player Health: " + CurrentEntity.Health);
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
