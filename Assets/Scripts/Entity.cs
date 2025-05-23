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
            if (value >= 0)
            {
                _health = value;
            }
            else
            {
                Debug.Log("Health needs to be set at a number greater than 0");
            }
        }
    }

    public void Damaged(int damage_amount)
    {
        Health -= damage_amount;
    }

    public void CheckIsAlive()
    {
        if (Health == 0)
        {
            Debug.Log("Died");
            Destroy(gameObject);
        }
    }
}
