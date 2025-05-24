using UnityEngine;

public class BaseAttack : MonoBehaviour, IAttack
{
    [SerializeField] private int _attackAmount = 1;
    [SerializeField] private Entity _currentEntity;
    public Entity CurrentEntity
    {
        get
        {
            return _currentEntity;
        }
        set
        {
            if (GameObject.FindWithTag("Player"))
            {
                _currentEntity = value;
            }
        }
    }
    public int AttackAmount
    {
        get
        {
            return _attackAmount;
        }
        set
        {
            // Makes sure attack amount is above zero or prints out that it needs to be above zero
            if (value > 0)
            {
                _attackAmount = value;
            }
            else
            {
                Debug.Log("Attack amount needs to be greater than 0");
            }
        }
    }

    // Updates the player's health
    public virtual void Attack()
    {
        return;
    }
}
