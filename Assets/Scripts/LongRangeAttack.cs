using Unity.Mathematics;
using UnityEngine;

public class LongRangeAttack : MonoBehaviour, IAttack
{
    [SerializeField] private Entity _player;
    [SerializeField] private int _attack_amount = 1;
    [SerializeField] private GameObject bullet;
    private Vector3 direction = Vector3.zero;
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
        Instantiate(bullet, transform);
    }

    private void Rotation()
    {
        direction = _player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle-90f));
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            timer = 0f;
            Attack();
        }

        Rotation();
    }

}
