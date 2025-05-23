using UnityEngine;

public class Entity : MonoBehaviour, IEntity
{
    // Set the health value to a number so it doesn't stay as 0 if the health is never set
    [SerializeField] private int _health = 2;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            /* Makes sure the health is greater than zero when the health is set
               else it prints out that the number needs to be greater than 0 and it doesn't change the health */
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

    // Subtracts from the health and checks if the player has died
    public void Damaged(int damage_amount)
    {
        Health -= damage_amount;
        CheckIsAlive();
    }

    // Makes sure that the health is above 0
    public void CheckIsAlive()
    {
        if (Health == 0)
        {
            Debug.Log("Died");
            Destroy(gameObject);
        }
    }
}
