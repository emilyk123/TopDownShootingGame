using Unity.VisualScripting;

public interface IEntity
{
    int Health { get; set; }
    void Damaged(int damage_amount);
    void CheckIsAlive();
}

public interface IAttack
{
    Entity CurrentEntity { get; set; }
    int AttackAmount { get; set; }
    void Attack();
}
