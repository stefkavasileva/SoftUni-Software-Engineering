public interface IWareHouse
{
    string Name { get; }

    int Count { get; }

    void AddAmmunitions(string ammunitionType, int count);

    void EquipArmy(IArmy army);
}
