public interface IEntity
{
    int Health { get; set; }
    void Damaged(int damage_amount);
    void Die();
}
