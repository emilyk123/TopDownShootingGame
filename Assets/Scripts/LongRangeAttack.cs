using Unity.Mathematics;
using UnityEngine;

public class LongRangeAttack : MonoBehaviour, IAttack
{
    [SerializeField] private Entity _player;
    [SerializeField] private int _attack_amount = 1;
    [SerializeField] private GameObject bullet;
    public Entity CurrentEntity { get; set; }
    public float timer = 0f;
    public float delay = 2f;
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

    public void Attack()
    {
        Instantiate(bullet, transform.position, quaternion.identity);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            timer = 0f;
            Attack();
        }
    }
}
