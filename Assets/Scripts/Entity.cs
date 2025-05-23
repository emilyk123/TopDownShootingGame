public interface IEntity
{
    int Health { get; set; }
    void Attack(int attack_amount);
    void Damaged(int damage_amount);
    void Move();
    void Die();
}