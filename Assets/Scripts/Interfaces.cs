// Entity interface used for the player and enemies for basic functions
public interface IEntity
{
    int Health { get; set; }
    // This will subtract the damage amount from the health
    void Damaged(int damage_amount);
    // This will make sure the health value is greater than 0
    void CheckIsAlive();
}

// Attack interface used for the player and enemies
public interface IAttack
{
    // This is the entity that is being attacked
    Entity CurrentEntity { get; set; }
    // This is how much damage the entity that is being attacked will take
    int AttackAmount { get; set; }
    // This will have the logic for the attack that will depend on if the attack is long or short ranged
    void Attack();
}
