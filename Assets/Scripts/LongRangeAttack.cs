using UnityEngine;

public class LongRangeAttack : BaseAttack
{
    [SerializeField] private GameObject bullet;
    // Will store the direction the player is in relative to this game object
    private Vector3 direction = Vector3.zero;
    public float timer = 0f;
    // Number of seconds the attack will be delayed by
    public float delay = 2f;

    public override void Attack()
    {
        // Spawn in the bullet in the direction of this game object
        Instantiate(bullet, transform.position, transform.rotation);
    }

    // Rotate this game object to face toward the player
    private void Rotation()
    {
        direction = CurrentEntity.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(Vector3.forward * (angle - 90f));
    }

    void Update()
    {
        // Delay how often the attack can happen
        timer += Time.deltaTime;
        if (timer > delay)
        {
            timer = 0f;
            Attack();
        }

        // Update the rotation of this game object to face the player
        Rotation();
    }

}
