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
    public void Attack()
    {
        Debug.Log("Player Health: " + CurrentEntity.Health);
        CurrentEntity.Damaged(AttackAmount);
        CurrentEntity.CheckIsAlive();
        Debug.Log("New Player Health: " + CurrentEntity.Health);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Attack();
        }
    }
}
