using UnityEngine;

public class Entity : MonoBehaviour, IEntity
{
    [SerializeField] private int _health = 2;
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

    public void Damaged(int damage_amount)
    {
        return;
    }

    public void Die()
    {
        return;
    }
}
