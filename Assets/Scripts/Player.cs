using UnityEngine;

public class Player : MonoBehaviour, IEntity
{
    private int _health = 0;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            if (value > 0)
            {
                _health = value;
            }
        }
    }

    public void Attack(int attack_amount)
    {
        return;
    }

    public void Damaged(int damage_amount)
    {
        return;
    }

    public void Move()
    {
        return;
    }

    public void Die()
    {
        return;
    }
}
