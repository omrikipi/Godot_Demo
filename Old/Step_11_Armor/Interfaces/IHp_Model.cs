namespace Interfaces;
public interface IHp_Model
{
    int Value { get; }
    int Armor { get; }
    void Reduce(int amount);
}
