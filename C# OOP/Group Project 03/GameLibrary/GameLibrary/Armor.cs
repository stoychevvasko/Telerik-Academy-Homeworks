namespace GameLibrary
{
    public class Armor : Item, IEquipable
    {
        public int critical { get; protected set; }

        public int health { get; protected set; }

        public int mojo { get; protected set; }

        public void Equip()
        {
            throw new System.NotImplementedException();
        }
    }
}