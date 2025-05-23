public interface IEntity
{
    int Health { get; set; }
    void Damaged(int damage_amount);
    void CheckIsAlive();
}

public interface IAttack
{
    void Attack();
}
